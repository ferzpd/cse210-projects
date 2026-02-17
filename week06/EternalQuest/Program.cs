using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.AddGoal(new SimpleGoal("Run Marathon", "Complete a marathon", 1000));
        manager.AddGoal(new EternalGoal("Read Scriptures", "Read daily", 100));
        manager.AddGoal(new ChecklistGoal("Attend Temple", "Go to temple", 50, 5, 500));
        manager.DisplayGoals();
        manager.DisplayScore();
        manager.RecordGoalEvent(1);
        manager.RecordGoalEvent(2);

        Console.WriteLine("\nAfter recording events:");
        manager.DisplayGoals();
        manager.DisplayScore();
    }
}