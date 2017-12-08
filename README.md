                                                             ,,                                   
     `7MMF'                                                `7MM                                   
       MM                                                    MM                                   
       MM         .gP"Ya   .P"Ybmmm .gP"Ya `7MMpMMMb.   ,M""bMM   ,6"Yb.  `7Mb,od8 `7M'   `MF'    
       MM        ,M'   Yb :MI  I8  ,M'   Yb  MM    MM ,AP    MM  8)   MM    MM' "'   VA   ,V      
       MM      , 8M""""""  WmmmP"  8M""""""  MM    MM 8MI    MM   ,pm9MM    MM        VA ,V       
       MM     ,M YM.    , 8M       YM.    ,  MM    MM `Mb    MM  8M   MM    MM         VVV        
     .JMMmmmmMMM  `Mbmmd'  YMMMMMb  `Mbmmd'.JMML  JMML.`Wbmd"MML.`Moo9^Yo..JMML.       ,V         
                          6'     dP                                                   ,V          
                          Ybmmmd'                                                  OOb"           
                                                                                                  
                   ,,          ,,                                                                 
     `7MMF'        db        `7MM                                                                 
       MM                      MM                                                                 
       MM        `7MM  ,p6"bo  MMpMMMb.  .gP"Ya `7MMpMMMb.  ,pP"Ybd                               
       MM          MM 6M'  OO  MM    MM ,M'   Yb  MM    MM  8I   `"                               
       MM      ,   MM 8M       MM    MM 8M""""""  MM    MM  `YMMMa.                               
       MM     ,M   MM YM.    , MM    MM YM.    ,  MM    MM  L.   I8                               
     .JMMmmmmMMM .JMML.YMbmd'.JMML  JMML.`Mbmmd'.JMML  JMML.M9mmmP'                               
                                                                                                  
                                                                                                  

	Legendary Lichens Team Members:

	Nathan Beyer, Chris Hoegger, Chris Menning, Leilani Ray




	What is Steganography?

	Steganography is the process of hiding messages inside of something else. In the case of 
	this program, you hide text messages inside of image files.



	Purpose:

	The purpose of this program is to allow the user to type a message in plain text 
	(ASCII only) and hide that message within the Least Significant Bit of each color channel
	of each pixel of a bitmap image. In this way, any message can be disguised as an unrelated
	image.


	How it Works:

	A rasterized bitmap can be thought of as a 2D array of pixels, arranged in rows and columns. 
	Each pixel has 4 color channels: Alpha (opacity), Red, Green, and Blue. Each color channel 
	stores 1 byte (8 bits) of information. Each bit in the byte that represents an individual 
	color channel of a pixel will be either a 1 or a 0; and changing the very last bit (the 
	Least Significant Bit, or LSB) in the byte will make such a tiny difference that it is 
	imperceptible to the human eye. This means that out of the 32 bits needed for storing a 
	color in a pixel, there are 4 bits that can be utilized for storing additional data, without
	changing the appearance of the image.

	In the ASCII text encoding, each character is represented by 1 byte of data. This means that 
	it takes 2 pixels to store 1 character from a string of ASCII characters. A keen observer of
	the Character Limit field on the main form might now be wondering why there are always 16 
	pixels that cannot store text. To keep the encoding and decoding processes efficient, the 
	need arose for storing an integer representing the length of the message. An integer takes 4
	bytes in memory, or 32 bits, hence the character computing formula of ((x * y) / 2) – 32.

	The optional AES Encryption can be set to utilize key sizes of 128, 192, or 256 bits. 
	Additionally, the password handler utilizes Rfc2898 for deriving an AES key directly from a 
	user-supplied password. Because encrypted messages take more space than unencrypted messages, 
	the amount of available text is estimated by dividing the original formula by 10 and 
	subtracting 2, based upon experimentation and observation using an image with the dimensions
	32 by 32.


