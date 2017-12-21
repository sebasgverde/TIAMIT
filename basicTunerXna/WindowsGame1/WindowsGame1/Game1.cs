using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using FftGuitarTuner;

///////////////////////////////////////////////////////////
//  Original author: sebastian
///////////////////////////////////////////////////////////

namespace WindowsGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        SpriteFont text;
        string generalString;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        int dif;
        String isDevice;

        // Declare a buffer array to hold the audio data based on the duration of the recording
        const double recordingSeconds = 0.5;
        byte[] buffer = new byte[Microphone.Default.GetSampleSizeInBytes(TimeSpan.FromSeconds(recordingSeconds))];
        
        double frequency;
        double closestFrequency;
        string noteName;

        // Tracks the amount of data recorded
        int bytesRead = 0;

        bool isMicrophoneRecording = false;
        int timeSpentRecording = 0;
        bool hasData = false;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            isDevice = captureAudio();
            if (!isMicrophoneRecording)
            //if (bytesRead < 100000)
            {
                // we are starting to record
                timeSpentRecording = 0;
                Microphone.Default.Start();
            }
            else
            {

                Microphone.Default.Stop();

                // mark the flag that we have some data available.
                hasData = true;
            }

            
            Content.RootDirectory = "Content";

            
        }

        public String captureAudio()
        {
            Microphone mic = Microphone.Default;
            if (mic == null)
            {
                return "no"; // No microphone is attached to the device
            }
            return "yes";

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            text = Content.Load<SpriteFont>("font");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        string[] NoteNames = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
        double ToneStep = Math.Pow(2, 1.0 / 12);

        void frequency2Note(double frequency, out double closestFrequency, out string noteName)
        {
            const double AFrequency = 440.0;
            const int ToneIndexOffsetToPositives = 120;

            int toneIndex = (int)Math.Round(Math.Log(frequency / AFrequency, ToneStep));
            noteName = NoteNames[(ToneIndexOffsetToPositives + toneIndex) % NoteNames.Length];
            closestFrequency = Math.Pow(ToneStep, toneIndex) * AFrequency;
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            if (bytesRead < buffer.Length)
            {

                // public int GetData (byte[] buffer,int offset,int count)
                // this method is really bad explained in msdn I almost had to do reverse engineering, 
                // it basically takes the whole recording 
                // and put the data in the buffer array starting in position offset and getting also the data from postion
                // offset, and maximal until position count, this way it fills gradualy the buffer array
                bytesRead += Microphone.Default.GetData(buffer, bytesRead, (buffer.Length - bytesRead));

                // in this case it just put in the buffer the last data obtained since last getdata called,
                // put it in buffer starting in pos 0, so you have to know the size of new data doing the difference
                // to know until where is the new data, this could be very useful, but I decided to use
                // samples of half second and then restart the buffer so is not necessary
                //
                //int old = bytesRead;
                //bytesRead += Microphone.Default.GetData(buffer);
                //dif = bytesRead - old; //dif-1 is the pos of last current element in buffer

                generalString += bytesRead + " ";


            }
            else
            {
                isMicrophoneRecording = true;
                //short[] ensayo = (short[])buffer;

                double MinFreq = 60;
                double MaxFreq = 1300;
                int SampleRate = 44100;

                // Scaling the samples to send to external method
                double[] scaledBuffer = new double[buffer.Length];
                for (int i = 0; i < scaledBuffer.Length; i++)
                {
                    // 255 is maximal number in byte type
                    scaledBuffer[i] = buffer[i] / 255.0;
                }

                // external method to find frequency
                // this can be replaced for any method with next description:
                // it must receive an array of scaleted samples of wav file and return the frequency
                frequency = FrequencyUtils.FindFundamentalFrequency(scaledBuffer, SampleRate, MinFreq, MaxFreq);

                if (frequency > 0)
                {
                    frequency2Note(frequency, out closestFrequency, out noteName);
                    Console.WriteLine(frequency.ToString("f2") + " " + closestFrequency.ToString("f2") + " " + noteName);
                }


                bytesRead = 0;
                isMicrophoneRecording = false;
            }
            base.Update(gameTime);
        }


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            // TODO: Add your drawing code here
            //spriteBatch.DrawString(text, buffer[0].ToString() + " " + buffer[dif] + " " + buffer[dif + 1] + " " + buffer[buffer.Length - 1].ToString(), new Vector2(10, 10), Color.White);
            spriteBatch.DrawString(text, "Bytes Recorded: " + bytesRead.ToString(), new Vector2(10, 50), Color.White);
            spriteBatch.DrawString(text, "Samples: " + generalString, new Vector2(10, 100), Color.White);
            spriteBatch.DrawString(text, "Frequency: " + frequency.ToString("f2"), new Vector2(10, 150), Color.White);
            spriteBatch.DrawString(text, "Closest note frequency: " + closestFrequency.ToString("f2"), new Vector2(10, 200), Color.White);
            spriteBatch.DrawString(text, "Note: " + noteName, new Vector2(10, 250), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
