namespace ThemeParkTycoonGame.Core
{
    public interface IDesirable
    {
        string GetRandomDesireReason();
        bool IsAvailable();
    }
}