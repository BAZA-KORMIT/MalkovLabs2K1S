namespace Interface;
public interface IMove<T>
{
    void Add(T data);
    T Remove();
    bool IsEmpty();
}

