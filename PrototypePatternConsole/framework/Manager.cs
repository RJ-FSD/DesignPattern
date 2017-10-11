using System.Collections;

namespace DesignPattern_Prototype.framework
{
    /// <summary>
    /// Client：ひな形インスタンスのコピーを指示するクラス
    /// </summary>
    class Manager
    {
        /// <summary>
        /// ひな形インスタンスを保持するHashtable
        /// </summary>
        private Hashtable showcase = new Hashtable();

        /// <summary>
        /// 引数で渡されたひな形インスタンスをshowcase内に格納する
        /// </summary>
        /// <param name="name"></param>
        /// <param name="proto"></param>
        public void Register(string name, IProduct proto)
        {
            showcase.Add(name, proto);
        }

        /// <summary>
        /// showcase内に存在するひな形インスタンスのコピーを返す
        /// </summary>
        /// <param name="protoname"></param>
        /// <returns></returns>
        public IProduct Create(string protoname)
        {
            IProduct p = (IProduct)showcase[protoname];
            return p.CreateClone();
        }
    }
}
