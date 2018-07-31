namespace Games
{
    public interface IGame<T>
    {
        void Play(T value);
        void ReArrage();
        void ReStart();
        void Exit();

    }
}