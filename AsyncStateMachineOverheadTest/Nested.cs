
using System.Threading.Tasks;
using System;
namespace AsyncStateMachineOverheadTest
{
    public partial class NestedAsync
    {
        public async ValueTask NestedYieldOnce2()
        {   
            await NestedYieldOnce1();
        }

        public async ValueTask NestedYieldEach2()
        {
            await Task.Yield();
            await NestedYieldEach1();
        }

        public async ValueTask NestedNoAsync2()
        {   
            await NestedNoAsync1();
        }

        public async ValueTask NestedYieldOnce3()
        {   
            await NestedYieldOnce2();
        }

        public async ValueTask NestedYieldEach3()
        {
            await Task.Yield();
            await NestedYieldEach2();
        }

        public async ValueTask NestedNoAsync3()
        {   
            await NestedNoAsync2();
        }

        public async ValueTask NestedYieldOnce4()
        {   
            await NestedYieldOnce3();
        }

        public async ValueTask NestedYieldEach4()
        {
            await Task.Yield();
            await NestedYieldEach3();
        }

        public async ValueTask NestedNoAsync4()
        {   
            await NestedNoAsync3();
        }

        public async ValueTask NestedYieldOnce5()
        {   
            await NestedYieldOnce4();
        }

        public async ValueTask NestedYieldEach5()
        {
            await Task.Yield();
            await NestedYieldEach4();
        }

        public async ValueTask NestedNoAsync5()
        {   
            await NestedNoAsync4();
        }

        public async ValueTask NestedYieldOnce6()
        {   
            await NestedYieldOnce5();
        }

        public async ValueTask NestedYieldEach6()
        {
            await Task.Yield();
            await NestedYieldEach5();
        }

        public async ValueTask NestedNoAsync6()
        {   
            await NestedNoAsync5();
        }

        public async ValueTask NestedYieldOnce7()
        {   
            await NestedYieldOnce6();
        }

        public async ValueTask NestedYieldEach7()
        {
            await Task.Yield();
            await NestedYieldEach6();
        }

        public async ValueTask NestedNoAsync7()
        {   
            await NestedNoAsync6();
        }

        public async ValueTask NestedYieldOnce8()
        {   
            await NestedYieldOnce7();
        }

        public async ValueTask NestedYieldEach8()
        {
            await Task.Yield();
            await NestedYieldEach7();
        }

        public async ValueTask NestedNoAsync8()
        {   
            await NestedNoAsync7();
        }

        public async ValueTask NestedYieldOnce9()
        {   
            await NestedYieldOnce8();
        }

        public async ValueTask NestedYieldEach9()
        {
            await Task.Yield();
            await NestedYieldEach8();
        }

        public async ValueTask NestedNoAsync9()
        {   
            await NestedNoAsync8();
        }

        public async ValueTask NestedYieldOnce10()
        {   
            await NestedYieldOnce9();
        }

        public async ValueTask NestedYieldEach10()
        {
            await Task.Yield();
            await NestedYieldEach9();
        }

        public async ValueTask NestedNoAsync10()
        {   
            await NestedNoAsync9();
        }

        public async ValueTask NestedYieldOnce11()
        {   
            await NestedYieldOnce10();
        }

        public async ValueTask NestedYieldEach11()
        {
            await Task.Yield();
            await NestedYieldEach10();
        }

        public async ValueTask NestedNoAsync11()
        {   
            await NestedNoAsync10();
        }

        public async ValueTask NestedYieldOnce12()
        {   
            await NestedYieldOnce11();
        }

        public async ValueTask NestedYieldEach12()
        {
            await Task.Yield();
            await NestedYieldEach11();
        }

        public async ValueTask NestedNoAsync12()
        {   
            await NestedNoAsync11();
        }

        public async ValueTask NestedYieldOnce13()
        {   
            await NestedYieldOnce12();
        }

        public async ValueTask NestedYieldEach13()
        {
            await Task.Yield();
            await NestedYieldEach12();
        }

        public async ValueTask NestedNoAsync13()
        {   
            await NestedNoAsync12();
        }

        public async ValueTask NestedYieldOnce14()
        {   
            await NestedYieldOnce13();
        }

        public async ValueTask NestedYieldEach14()
        {
            await Task.Yield();
            await NestedYieldEach13();
        }

        public async ValueTask NestedNoAsync14()
        {   
            await NestedNoAsync13();
        }

        public async ValueTask NestedYieldOnce15()
        {   
            await NestedYieldOnce14();
        }

        public async ValueTask NestedYieldEach15()
        {
            await Task.Yield();
            await NestedYieldEach14();
        }

        public async ValueTask NestedNoAsync15()
        {   
            await NestedNoAsync14();
        }

        public async ValueTask NestedYieldOnce16()
        {   
            await NestedYieldOnce15();
        }

        public async ValueTask NestedYieldEach16()
        {
            await Task.Yield();
            await NestedYieldEach15();
        }

        public async ValueTask NestedNoAsync16()
        {   
            await NestedNoAsync15();
        }

        public async ValueTask NestedYieldOnce17()
        {   
            await NestedYieldOnce16();
        }

        public async ValueTask NestedYieldEach17()
        {
            await Task.Yield();
            await NestedYieldEach16();
        }

        public async ValueTask NestedNoAsync17()
        {   
            await NestedNoAsync16();
        }

        public async ValueTask NestedYieldOnce18()
        {   
            await NestedYieldOnce17();
        }

        public async ValueTask NestedYieldEach18()
        {
            await Task.Yield();
            await NestedYieldEach17();
        }

        public async ValueTask NestedNoAsync18()
        {   
            await NestedNoAsync17();
        }

        public async ValueTask NestedYieldOnce19()
        {   
            await NestedYieldOnce18();
        }

        public async ValueTask NestedYieldEach19()
        {
            await Task.Yield();
            await NestedYieldEach18();
        }

        public async ValueTask NestedNoAsync19()
        {   
            await NestedNoAsync18();
        }

        public async ValueTask NestedYieldOnce20()
        {   
            await NestedYieldOnce19();
        }

        public async ValueTask NestedYieldEach20()
        {
            await Task.Yield();
            await NestedYieldEach19();
        }

        public async ValueTask NestedNoAsync20()
        {   
            await NestedNoAsync19();
        }

    }
}