using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp2.Properties
{
    [CompilerGenerated, DebuggerNonUserCode, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    internal class ResourcesBase1
    {
        internal static Image AnaSayfaResim;
        private static CultureInfo resourceCulture;
        private static ResourceManager resourceMan;

        /// <summary>
        ///   Geçerli iş parçacığının CurrentUICulture özelliğini geçersiz kılar.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get { return resourceCulture; }
            set { resourceCulture = value; }
        }

        /// <summary>
        ///   Bu sınıf tarafından kullanılan önbelleğe alınmış ResourceManager örneğini döndürür.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    resourceMan = new ResourceManager("WindowsFormsApp2.Properties.Resources", typeof(Resources).Assembly);
                }
                return resourceMan;
            }
        }
    }
}