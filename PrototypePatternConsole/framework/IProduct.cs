namespace DesignPattern_Prototype.framework
{
    /// <summary>
    /// Prototype：複製を行うメソッドを定義するインターフェイス
    /// </summary>
    interface IProduct
    {
        IProduct CreateClone();

        void Use(string s);
    }
}
