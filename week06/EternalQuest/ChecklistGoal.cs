public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }
    public override void RecordEvent()
    {
        _currentCount++;
    }
    public override string GetDetailsString()
    {
        string status = _currentCount >= _targetCount ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount}";
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }
}