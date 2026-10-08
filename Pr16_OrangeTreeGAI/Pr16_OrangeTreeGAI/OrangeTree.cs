using System;
using System.Collections.Generic;
using System.Text;

namespace Pr16_OrangeTreeGAI;

public class OrangeTree
{
    private int age;
    private int height;
    private bool treeAlive;
    private int numOranges;
    private int orangesEaten;

    public void SetAge(int age) => this.age = age;
    public int GetAge() => age;

    public void SetHeight(int height) => this.height = height;
    public int GetHeight() => height;

    public void SetTreeAlive(bool treeAlive) => this.treeAlive = treeAlive;
    public bool GetTreeAlive() => treeAlive;

    public int GetNumOranges() => numOranges;
    public int GetOrangesEaten() => orangesEaten;

    public void OneYearPasses()
    {
        age++;
        orangesEaten = 0;

        if (age >= 80)
        {
            treeAlive = false;
        }

        if (treeAlive)
        {
            height += 2;

            if (age >= 2)
            {
                numOranges = 5 + (age - 2) * 5;
            }
        }
        else
        {
            numOranges = 0;
        }
    }

    public void EatOrange(int count)
    {
        if (count > numOranges)
        {
            count = numOranges;
        }

        numOranges -= count;
        orangesEaten += count;
    }
}
