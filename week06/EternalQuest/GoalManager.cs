using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void RecordGoalEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();
            _score += goal.GetPoints();
            if (goal is ChecklistGoal checklist && checklist.IsComplete())
            {
                _score += checklist.GetBonusPoints();
            }
        }
    }
    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }
}