using M.Resources.Fonts;

namespace MyFont
{
    public class MetaInfo : Font
    {
        public MetaInfo()
        {
            //这里的信息将显示在游戏内的设置界面上
            #region 基本信息

            //字体叫什么名字?(字符串)
            Name = "";

            //你对该字体有什么地方要描述?(字符串)
            Description = "";

            //这个字体的作者/版权方是谁?(字符串)
            Author = "";

            //这个字体有什么协议吗?(字符串)
            License = "";

            //这个字体的主页在哪里?(字符串)
            Homepage = "";

            #endregion 基本信息


            //这里的信息将决定哪些变体可用，以及要如何寻找字体
            //请正确填写, 加载时将根据这里的值在dll中寻找你制作的字体
            #region 字体信息

            //Light变体可用吗?(true -> 可用 | false -> 不可用)
            LightAvaliable = false;

            //Medium变体可用吗?(true -> 可用 | false -> 不可用)
            MediumAvaliable = false;

            //SemiBold变体可用吗?(true -> 可用 | false -> 不可用)
            SemiBoldAvaliable = false;

            //Bold变体可用吗?(true -> 可用 | false -> 不可用)
            BoldAvaliable = false;

            //Black变体可用吗?(true -> 可用 | false -> 不可用)
            BlackAvaliable = false;

            //这个字体的家族名叫什么?(字符串)
            FamilyName = "";

            #endregion 字体信息
        }
    }
}
