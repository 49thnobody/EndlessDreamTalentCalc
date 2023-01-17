internal class Calculations
{
    public Calculations(int totalPoints)
    {
        TotalPoints = totalPoints;
    }

    public int TotalPoints { get; }
    public int Grade1 { get => _grade1; set => Set(ref _grade1, value); }
    private int _grade1;
    public int Grade2 { get => _grade2; set => Set(ref _grade2, value); }
    private int _grade2;
    public int Grade3 { get => _grade3; set => Set(ref _grade3, value); }
    private int _grade3;
    public int Grade4 { get => _grade4; set => Set(ref _grade4, value); }
    private int _grade4;

    private void Set(ref int field, int value)
    {
        if (value < 0) return;

        field = value;
    }

    public override string ToString()
    {
        return $"Total points: {TotalPoints}\n" +
               $"Grade 1 points: {Grade1}\n" +
               $"Grade 2 points: {Grade2}\n" +
               $"Grade 3 points: {Grade3}\n" +
               $"Grade 4 points: {Grade4}\n";
    }
}
