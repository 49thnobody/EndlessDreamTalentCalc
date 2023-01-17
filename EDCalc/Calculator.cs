internal static class Calculator
{
    public static Calculations Calculate(int talentPoints, int pointSpent)
    {
        Calculations calculations = new Calculations(talentPoints + pointSpent);

        int spent = 0;

        while (spent <= calculations.TotalPoints)
        {
            spent++;
            if (spent / 100 > calculations.Grade4)
            {
                calculations.Grade4++;
                continue;
            }

            if (spent / 10 > calculations.Grade3)
            {
                calculations.Grade3++;
                continue;
            }

            if (spent / 5 > calculations.Grade2)
            {
                calculations.Grade2++;
                continue;
            }

            calculations.Grade1++;
        }

        return calculations;
    }
}