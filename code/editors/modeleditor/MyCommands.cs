using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DevComponents.WpfRibbon;

namespace ModelEditor
{
    /// <summary>
    /// Defines the sample application commands used by the Ribbon Control.
    /// </summary>
    public class MyCommands
    {
        /// <summary>
        /// Defines Most Recently Used Item command.
        /// </summary>
        public static RoutedCommand MostRecentlyUsed = new RoutedCommand();

        /// <summary>
        /// Defines Close Document command. Note how Header and Images are set. They do not have to be set on ButtonDropDown instances that use this command since they will be
        /// automatically picked up.
        /// </summary>
        public static ButtonDropDownCommand CloseDocument = new ButtonDropDownCommand("�ر�", "closeDoc", "/images/FolderClosed32.png", typeof(Ribbon));

        /// <summary>
        /// Defines ModelEditor Options command.
        /// </summary>
        public static ButtonDropDownCommand Options = new ButtonDropDownCommand("ѡ��", "options", "/images/Options.png", typeof(Ribbon));

        /// <summary>
        /// Defines Blue Color Scheme command.
        /// </summary>
        public static ButtonDropDownCommand BlueTheme = new ButtonDropDownCommand("��ɫ����", "blueTheme", "/images/SchemeBlue.png", "/images/SchemeBlue16.png", typeof(Ribbon));

        /// <summary>
        /// Defines Silver Color Scheme command.
        /// </summary>
        public static ButtonDropDownCommand SilverTheme = new ButtonDropDownCommand("��ɫ����", "silverTheme", "/images/SchemeSilver.png", "/images/SchemeSilver16.png", typeof(Ribbon));

        /// <summary>
        /// Defines Black Color Scheme command.
        /// </summary>
        public static ButtonDropDownCommand BlackTheme = new ButtonDropDownCommand("��ɫ����", "blackTheme", "/images/SchemeBlack.png", "/images/SchemeBlack16.png", typeof(Ribbon));

        /// <summary>
        /// Defines Orange Color Scheme command.
        /// </summary>
        public static ButtonDropDownCommand OrangeTheme = new ButtonDropDownCommand("�ٻ�", "orangeTheme", typeof(Ribbon));

        /// <summary>
        /// Defines Magenta Color Scheme command.
        /// </summary>
        public static ButtonDropDownCommand MagentaTheme = new ButtonDropDownCommand("Ʒ��", "magentaTheme", typeof(Ribbon));

        /// <summary>
        /// Defines Green Color Scheme command.
        /// </summary>
        public static ButtonDropDownCommand GreenTheme = new ButtonDropDownCommand("ɭ����", "greenTheme", typeof(Ribbon));

        /// <summary>
        /// Defines Dark Blue Color Scheme command.
        /// </summary>
        public static ButtonDropDownCommand DarkBlueTheme = new ButtonDropDownCommand("����", "darkBlueTheme", typeof(Ribbon));
    }
}