/*
 * STARTUP : VM UP
 * AUTHOR  : JOSÉ ALBERTO GURGEL CARDOSO NETO
 * VERSION : 1.0
 * *********************************************************
 * THIS CLASS RETURNS A SQUARE WAVE, WHICH INITIALIZES IN
 * HIGH LEVEL, GOING TO LOW LEVEL AFTER timeHigh SECONDS
 */

using System;

public class SquareWave
{
    private float       peep;
    private float       pcAbovePeep;
    private float       frequency;
    private float       period;
    private float       timeHigh;
    private const float DUTY_CYCLE = 1.0f/3.0f;

    public SquareWave(float peep, float pcAbovePeep, float frequency)
    {
        this.peep        = peep;
        this.frequency   = frequency;
        this.pcAbovePeep = pcAbovePeep;
        this.period      = 1/frequency;
        this.timeHigh    = this.period * DUTY_CYCLE;
    }

    public void SetPeep(float peep)
    {
        this.peep = peep;
    }

    public void SetPcAbovePeep(float pcAbovePeep)
    {
        this.pcAbovePeep = pcAbovePeep;
    }

    public void SetFrequency(float frequency)
    {
        this.frequency = frequency;
        this.period    = 1 / frequency;
        this.timeHigh  = this.period * DUTY_CYCLE;
    }

    public float PlotSquareWave(float time)
    {
        time = time % this.period;

        if(time <= this.timeHigh)
            return (this.peep+this.pcAbovePeep);
        else
            return this.peep;
    }
}