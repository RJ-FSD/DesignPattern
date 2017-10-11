using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    //-------------------------------------------------------------
    //  デザインパターンBridge 
    //      機能と実装を分離してそれぞれ独立に拡張できるようにします。
    //
    //-------------------------------------------------------------
    //機能の抽象化
    //「機能とはあらかた予定されているもの」
    //「機能」はImplementorの操作を組み合わせて実装されます。
    public abstract class Abstraction_Cleaner
    {
        private List<Implementor> ImpCollection = new List<Implementor>();

        //実装をプロパティとして保持します。
        public List<Implementor> PropImplementor
        {
            set { this.ImpCollection = value; }
            get { return this.ImpCollection; }
        }

        //このメソッドで、Media機能の実行を定義します。
        public virtual void Operation()
        {
            foreach (Implementor Imp in ImpCollection)
            {
                Imp.OperationImp();
            }
        }

    }

    //機能の拡張
    //機能はImprementor（実行操作）でもって実装されます。
    //Imprementor（実行操作）の操作の組み合わせで、それぞれ異なる目的に
    //使用出来るようにすることができます。

    //AC100Vタイプのクリーナの定義
    public class RefinedAbstraction_AC100VType : Abstraction_Cleaner
    {
    }

    //コードレスクリナーの定義
    public class RefinedAbstraction_CodeLess : Abstraction_Cleaner
    {
    }


    //実装者
    public abstract class Implementor
    {
        public abstract void OperationImp();
    }

    //具象実装サイクロンタイプ（実際の内容）
    public class ConcreteImplementor_CycloneType : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("サイクロン方式は、紙フィルタがいらない強い吸引力です。");
        }
    }

    //具象実装フィルタータイプ(実際の内容)
    public class ConcreteImplementor_FilterType : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("紙フィルタでごみをとります。安価なのもGood");
        }
    }

    //具象実装パワーブラシ（実際の内容）
    public class ConcreteImplementor_PowerBrushType : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("絨毯でも大丈夫");
        }
    }

    /// <summary>
    /// Class1 の概要の説明です。
    /// </summary>
    //class Class1
    //{
    //    /// <summary>
    //    /// アプリケーションのメインエントリポイントです。
    //    /// </summary>
    //    [STAThread]
    //    static void Main(string[] args)
    //    {
    //        //拡張機能クラスのインスタンスの抽象機能を定めます。
    //        //各インスタンスは、Media機能がそれぞれ実装の拡張を受けている
    //        //ことを確認します。

    //        Abstraction_Cleaner AC100V_Cleaner = new RefinedAbstraction_AC100VType();
    //        Abstraction_Cleaner CodeLess_Cleaner = new RefinedAbstraction_CodeLess();

    //        //各オブジェクトに具象実装を実装します。

    //        //AC100Vクリナーにはサイクロンを実装
    //        AC100V_Cleaner.PropImplementor.Add(new ConcreteImplementor_CycloneType());

    //        //コードレスクリナーにはフィルタとパワーブラシを実装
    //        CodeLess_Cleaner.PropImplementor.Add(new ConcreteImplementor_FilterType());
    //        CodeLess_Cleaner.PropImplementor.Add(new ConcreteImplementor_PowerBrushType());
    //        //機能拡張されたオブジェクトの振る舞い
    //        AC100V_Cleaner.Operation();
    //        CodeLess_Cleaner.Operation();

    //        //------------------------------------------------------------
    //        //  ポイント機能と実装を分離する
    //        //
    //        //  実装の違いで同一の機能を行いたい場合
    //        //  (クラスの実装がその実行環境に依存する場合など)    その実装をクラスの
    //        //  機能と分離することで、それぞれの拡張を独立して行えるようになります。
    //        //
    //        //------------------------------------------------------------
    //    }
    //}
}