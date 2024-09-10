public class GameEvent
{
    private object[] m_list;

    public GameEvent(params object[] _list)
    {
        this.m_list = _list;
    }

    public object[] GetParameters()
    {
        return m_list;
    }
}
