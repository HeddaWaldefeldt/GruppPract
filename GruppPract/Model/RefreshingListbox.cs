using System.Windows.Forms;

namespace GruppPract
{
    /// <summary>
    /// A ListBox-control that allows access to RefreshItem(s)-Method(s).
    /// </summary>
	public class RefreshingListBox : ListBox
    {
        public new void RefreshItem(int index)
        {
            base.RefreshItem(index);
        }

        public new void RefreshItems()
        {
            base.RefreshItems();
        }
    }
}
