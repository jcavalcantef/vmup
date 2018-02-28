/*
 * STARTUP : VM UP
 * AUTHOR  : JOSÉ ALBERTO GURGEL CARDOSO NETO
 * VERSION : 1.0
 * *********************************************************
 * THIS CLASS RETURNS A VALUE RELATIVE TO OXYGEN SATURATION
 * BASED ON SELECTED PEEP AND OXYGEN CONCENTRATION VALUES
 */

using System;

public class OxygenSaturation
{
    private int spO2;//Oxygen Saturation

    public bool isWithinNormalCondition;

	public OxygenSaturation(int concentracaoO2, int PEEP)
	{
        this.spO2 = 91;

        getSaturation(concentracaoO2, PEEP);
	}

    public string getSaturation(int concentracaoO2, int PEEP)
    {
        bool condition1 = (concentracaoO2 >= 50f) && (concentracaoO2 <= 80f);
        bool condition2 = (PEEP >= 3) && (PEEP <= 5);
        bool condition3 = PEEP <= 2;

        if (condition1 ^ condition2 && !condition3)
        {
            this.spO2 = 93;
            isWithinNormalCondition = false;
        }
        else if (condition1 && condition2)
        {
            this.spO2 = 97;
            isWithinNormalCondition = true;
        }
        else if (condition3)
        {
            this.spO2 = 91;
            isWithinNormalCondition = false;
        }

        return (this.spO2.ToString());
    }
}