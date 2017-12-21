TIAMIT,  is an open source project to learn to read music with different insturments using gamefication. It is based in tha idea of visual memory, the user will see the notes in the music sheet and the positions where these notes are in the insturment, a sound capture and analysis module will check the notes played giving a final score of the performance. It also has a database engine where different users can be ranked and see their performances. 

# Demo of Instruments:

Guitar

[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/frhorIqbi4A/0.jpg)](https://www.youtube.com/watch?v=frhorIqbi4A)

E Diatonic Harmonica

[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/Uaji56TpZcw/0.jpg)](https://www.youtube.com/watch?v=Uaji56TpZcw)

# General Demo
[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/ABoe32i46O4/0.jpg)](https://www.youtube.com/watch?v=ABoe32i46O4)

# Adding a new instrument
Basically the procedure is:
- copy one of the BackgroundGame png in content
- Replace the instument image
- copy the notesPositionsTemplate.xml in content/metadata
- insert the positions of the notes
- add the files tovisual studio project
- add the support of the instrument in the code, this means modify these 3 methods:
    - TiamitMainForm.TiamitMainForm()
    - Interpretacion.LoadContent()
    - CargarCancionControlador.fullIntrumentPositions()

# Using the simple game without forms and databse
Just comment the line 

TiamitMainFormControlador g = new TiamitMainFormControlador();

in Program.cs and use the commented lines as template to call directly the game

GestionarInterpretacionControlador g = new GestionarInterpretacionControlador("<path>/everyNoteE4E8.xml", "Guitar");

# Deploying Database
- You need a working instance of a database server
- If it is Sql server, use the tiamit.sql script to create the DB
- If is other engine use the script as example of the needed tables and store procedures names
- Get the string connection
- Replace it in ConexionBD.Conexion()

# Technical details:

## Requirements:
- visual studio > 2010
- Microsoft XNA Game Studio 4.0
- for database support was tested using
    - local
        - Sql server express 2008 and Sql server management studio 2008
        - Sql server express 2012 and Sql server management studio 2012
    - Remote
        - Sql server express 2012 in Azure instance

## Music and Audio Considerations
In this project C4 is considered as central c (Acoustical Society of America (ASA) ) for the frequency detector
https://es.wikipedia.org/wiki/Do_(nota)

### Guitar:
However for the xml notespostions files, this will depend on the intrument, 
so for example guitar which is a Low transposing instrument (sounding an octave lower than written) (https://en.wikipedia.org/wiki/List_of_musical_instruments_by_transposition)
the C3 will have the postions of 5th string fret 3 and 6th string fret 8 (which correspond with the real pith of c3 130,81) but the position in the sheet will be the one of central C (C4)

String/Fret Note Frequency

Sixth Open E 82.407 
1 F 87.307 
2 F#/G 92.499 
3 G 97.999 
4 G#/A 103.826 

Fifth Open A 110.000 
1 A#/B 116.541 
2 B 123.471 
3 C 130.813 
4 C#/D 138.591 

Fourth Open D 146.832 
1 D#/E 155.563 
2 E 164.814 
3 F 174.614 
4 F#/G 184.997 

Third Open G 195.998 
1 G#/A 207.652 
2 A 220.000 
3 A#/B 233.082 

Second Open B 246.942 
1 C 261.626 (Middle C) 
2 C#/D 277.183 
3 D 293.665 
4 D#/E 311.127 

First Open E 329.628 
1 F 349.228
2 F#/G 369.994 
3 G 391.995 
4 G#/A 415.305 
5 A 440.000

The best way to test the positions xml for guitar is to use the musicxml called everyNoteE2E6.xml

### E Diatonic Harmonica
For the diatonic Harmonica the positions in sheet corresponds exactly to the notes

action |1 | 2 | 3 |4 |5 |6 |7|8|9|10
--- | --- | --- | --- | --- | --- | --- | --- | --- | --- | ---
blow|	E|	G#|	B	|E	|G#	|B|	E|	G#|	B|	E
draw|	F#|	B|	D♯|	F#	|A|	C#|	D♯|	F#|	A|	C#

## Some helping positions in game

### Y positions of fundamental notes in sheet

D4	<posSheet>402</posSheet>
E4	<posSheet>393</posSheet>		  
F4	<posSheet>383</posSheet>
G4	<posSheet>373</posSheet>	
A4	<posSheet>363</posSheet>	
B4	<posSheet>352</posSheet>
C5	<posSheet>343</posSheet>			   
D5	<posSheet>332</posSheet>		   
E5	<posSheet>321</posSheet>	
F5	<posSheet>310</posSheet>			  			  
G5	<posSheet>303</posSheet>

### Guitar strings Y positions
1 20
2 47
3 74
4 108
5 140
6 170


# Future work and/or Contributors Ideas:
- Octave support in recognition: for now it works, as always say the correct note is sounding, hats enough for now, but seems having some problems with the exact hertz of the octave, so for now is not always posible to detect the exact octave, only the note
    - identify de octave
    - some problems in detection (it says C4 is 65 hertz (c2))
- Paint notes out of sheet in correct position (lower than D4 and higher thatn G5)
- It could be interesting in order of add instruments easily, to put the seeht positions in an indepent xml that corresponds exact with the ASA notation (C4 261 Hz), and in the postion instruments xml put the information about the transposition
- After finish a lesson it should return to form but close (when you close the lesson it works)
- When adding insturments one have to put the list in many parts in code, could be good to have a central way to do it




