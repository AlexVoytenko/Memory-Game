namespace B20_Ex02_Itay_311446876_Alex_322038399
{ 
    internal class Cell<T>
    {
        private T m_ObjInCell;
        private bool m_IsExposed = false;

        internal Cell(T i_ObjToSet)
        {
            m_ObjInCell = i_ObjToSet;
        }

        internal T ObjInCell
        {
            get { return m_ObjInCell; }
            set { m_ObjInCell = value; }
        }

        internal bool IsExposed
        {
            get { return m_IsExposed; }
            set { m_IsExposed = value; }
        }
    }
}
