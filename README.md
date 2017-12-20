# TIAMIT 
TIAMIT Is Another Musical Instrument Trainer


Demo of Intruments:

Guitar

[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/frhorIqbi4A/0.jpg)](https://www.youtube.com/watch?v=frhorIqbi4A)

E Diatonic Harmonica

[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/Uaji56TpZcw/0.jpg)](https://www.youtube.com/watch?v=Uaji56TpZcw)


In this project C4 is considered as central c (Acoustical Society of America (ASA) ) for the frequency detector

https://es.wikipedia.org/wiki/Do_(nota)

String/Fret Note Frequency - more specific

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

https://en.wikipedia.org/wiki/List_of_musical_instruments_by_transposition
However for the xml notespostions files, this will depend on the intrument, 
so for example guitar which is a Low transposing instrument (sounding an octave lower than written)
the C3 will have the postions of 5th string fret 3 and 6th string fret 8 (which correspond with the real
pith of c3 130,81) but the position in the sheet will be the one of central C (C4)

The best way to test the positions xml for guitar is to use the musicxml called everyNoteE2E6.xml



Y positions of fundamental notes in sheet

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

guitar strings Y positions
1 20
2 47
3 74
4 108
5 140
6 170

For the diatonic Harmonica the positions in sheet corresponds exactly to the notes

		1	2	3	4	5	6	7	8	9	10
blow	E	G#	B	E	G#	B	E	G#	B	E
draw	F#	B	D♯	F#	A	C#	D♯	F#	A	C#

Add instrument
TiamitMainForm - TiamitMainForm()
Interpretacion - LoadContent()
CargarCancionControlador - fullIntrumentPositions()
