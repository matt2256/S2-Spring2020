using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;


namespace CRUD_med_Serier.ViewModel
{
    public class Visuals
    {

        #region Visual Controls
        //Buttons
        Button BtnCreate = new Button();
        Button BtnUpdate = new Button();
        Button BtnDelete = new Button();

        //Textbox
        TextBox TbNavn = new TextBox();
        TextBox TbUdgivelsesÅr = new TextBox();
        TextBox TbInstruktør = new TextBox();
        TextBox TbRating = new TextBox();

        //Labels
        Label LbNavn = new Label();
        Label LbUdgivelsesÅr = new Label();
        Label LbInstruktør = new Label();
        Label LbRating = new Label();

        //Datagrid
        DataGrid DtgInfo = new DataGrid();  
        #endregion


        #region Buttons
        //Create
        public void Create()
        {
            BtnCreate.Content = "Create";
            BtnCreate.Height = 20;
            BtnCreate.Width = 100;
            BtnCreate.Margin = new Thickness(5);
        }

        //Delete
        public void Delete()
        {
            BtnDelete.Content = "Delete";
            BtnDelete.Height = 20;
            BtnDelete.Width = 100;
            BtnDelete.Margin = new Thickness(5);
        }
        //Update
        public void Update()
        {
            BtnUpdate.Content = "Update";
            BtnUpdate.Height = 20;
            BtnUpdate.Width = 100;
            BtnUpdate.Margin = new Thickness(5);
        }
        #endregion

        #region Datagrid
        //Datagrid
        public void ShowInfo()
        {

        }
        #endregion

        #region Textbox
        //Textbox
        public void Navn()
        {
            TbNavn.Height = 20;
            TbNavn.Width = 100;
            TbNavn.Margin = new Thickness(5);
        }

        public void UdgivelsesÅr()
        {
            TbUdgivelsesÅr.Height = 20;
            TbUdgivelsesÅr.Width = 100;
            TbUdgivelsesÅr.Margin = new Thickness(5);
        }
        public void Instruktør()
        {
            TbInstruktør.Height = 20;
            TbInstruktør.Width = 100;
            TbInstruktør.Margin = new Thickness(5);
        }
        public void Rating()
        {
            TbRating.Height = 20;
            TbRating.Width = 100;
            TbRating.Margin = new Thickness(5);
        }
        #endregion

        #region Label
        //Label
        public void LabelNavn()
        {
            LbNavn.Content = "Navn";
            LbNavn.Height = 20;
            LbNavn.Width = 100;
            LbNavn.Margin = new Thickness(5);
        }
        public void LabelUdgivelsesÅr()
        {
            LbUdgivelsesÅr.Content = "Udgivelses år";
            LbUdgivelsesÅr.Height = 20;
            LbUdgivelsesÅr.Width = 100;
            LbUdgivelsesÅr.Margin = new Thickness(5);
        }
        public void LabelInstruktør()
        {
            LbInstruktør.Content = "Instruktør";
            LbInstruktør.Height = 20;
            LbInstruktør.Width = 100;
            LbInstruktør.Margin = new Thickness(5);
        }

        public void LabelRating()
        {
            LbRating.Content = "Rating";
            LbRating.Height = 20;
            LbRating.Width = 100;
            LbRating.Margin = new Thickness(5);
        }
        #endregion

    }
}
