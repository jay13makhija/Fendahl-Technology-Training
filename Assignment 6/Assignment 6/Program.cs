/*                                  Assignment 6: 

--> Answer the follwoing type casts operations 
	1. Can we cast booleans to other types implicitly ? if yes/no then why ? 
	2. Can we cast char to int implicitly ? if yes then why ?   
	3. Can we cast int to char implicitly ? if yes/no then why ?  
	4. Can we cast long to float implicitly ? if yes/no then why ?  */

using System;

public class Conversion
{
    public static void Conversions()
    {
        int i = 10;
        bool b = true;
        char c = 'a';
        long l = 12345;

        int i2 = b;   // No   bool can't
        int i3 = c;   // Yes
        char c2 = i;  // No    but can be done explicitly
        float f = l;  // Yes

        char c4 = (char)i; // Explicity 

    }
}