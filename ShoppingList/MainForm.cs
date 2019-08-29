using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    // uses ItemManager and ShoppingItem object
    public partial class MainForm : Form
    {
        ItemManager myItemManager = new ItemManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            comboBox.Items.AddRange( Enum.GetNames (typeof(UnitTypes) ) );
            comboBox.SelectedIndex = (int)UnitTypes.piece;
        }

        private void updateGUI()
        {
            listShoppingItems.Items.Clear();
            listShoppingItems.Items.AddRange( myItemManager.GetItemsInfoStrings() );
            //string[] itemStrings = myItemManager.GetItemsInfoStrings();

            //if (itemStrings != null)
            //{
            //    listBoxShoppingList.Items.AddRange(itemStrings);
            //}
            //else
            //{
            //    return;
            //}
        }

        /// <summary>
        /// read user user input and provides error messages on incorrect input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool isInputValid = false;

            ShoppingItem myShoppingitem = ReadInput(out isInputValid);

            if (isInputValid)
            {
                myItemManager.AddItem(myShoppingitem);
                updateGUI();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private ShoppingItem ReadInput(out bool isInputValid)
        {
            isInputValid = false;

            ShoppingItem myShoppingitem = new ShoppingItem();

            myShoppingitem.Description = ReadDescription(out isInputValid);

            if (!isInputValid)
            {
                return null;
            }

            myShoppingitem.Amount = ReadAmount(out isInputValid);

            if(!isInputValid)
            {
                return null;
            }

            myShoppingitem.Unit = ReadUnit(out isInputValid);

            return myShoppingitem;
        }

        private double ReadAmount(out bool isInputValid)
        {
            double amount = 0.0;
            isInputValid = false;

            if ( !double.TryParse(textBoxAmount.Text, out amount) )
            {
                GiveMessage("Incorrect amount");

                textBoxAmount.Focus();
                textBoxAmount.SelectionStart = 0;
                textBoxAmount.SelectionLength = textBoxAmount.TextLength;
            }
            else
            {
                isInputValid = true;
            }
            return amount;
        }

        private UnitTypes ReadUnit(out bool isInputValid)
        {
            isInputValid = false;
            UnitTypes myUnit = UnitTypes.lb;

            if (comboBox.SelectedIndex >= 0)
            {
                isInputValid = true;
                myUnit = (UnitTypes)comboBox.SelectedIndex;
            }
            else
            {
                GiveMessage("Incorrect unit");
            }
            return myUnit;
        }

        private void GiveMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string ReadDescription(out bool success)
        {
            success = false;

            string text = textBoxDescription.Text.Trim();

            if (!string.IsNullOrEmpty (text) )
            {
                success = true;
            }
            else
            {
                GiveMessage("Please provide a description");
            }

            return text;
        }

        private void listShoppingItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listShoppingItems.SelectedIndex < 0)
            {
                return;
            }

            ShoppingItem myShoppingItem = myItemManager.GetItem(listShoppingItems.SelectedIndex);

            textBoxAmount.Text = myShoppingItem.Amount.ToString();
            textBoxAmount.Text = myShoppingItem.Description;
            listShoppingItems.SelectedIndex = (int)myShoppingItem.Unit;

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void c_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}