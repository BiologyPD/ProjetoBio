﻿using ProjetoBio.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enum = ProjetoBio.Animais.Enum;

namespace ProjetoBio.Utils
{
    public static class ComboBoxExtensions
    {
        public static void SetFrom<T>(this ComboBox comboBox) where T : Enum
        {
            comboBox.Items.Clear();
            comboBox.DataSource = KeyPair.GetKeyPairs<T>();
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
        }
    }

    public static class CheckedListBoxExtensions
    {
        public static void SetFrom<T>(this CheckedListBox checkedListBox) where T : Enum
        {
            checkedListBox.CheckOnClick = true;
            checkedListBox.Items.Clear();
            checkedListBox.DataSource = KeyPair.GetKeyPairs<T>();
            checkedListBox.DisplayMember = "Key";
            checkedListBox.ValueMember = "Value";
        }

        public static T[] CheckedValues<T>(this CheckedListBox checkedListBox) where T : Enum
        {
            // auto-generated
            // checkedListBox.CheckedItems[0].GetType().GetType().GetProperty("Value").GetValue(checkedListBox.CheckedItems[0], null); 
            return checkedListBox.CheckedItems.Cast<KeyPair<T>>().Select(x => x.Value).ToArray();
        }

        public static void CheckFrom<T>(this CheckedListBox checkedListBox, params T[] values) where T : Enum
        {
            foreach (var value in values)
                checkedListBox.SetItemChecked(checkedListBox.FindString(value.Text), true);
        }

        public static void CheckAll(this CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
                checkedListBox.SetItemChecked(i, true);
        }

        public static void UncheckAll(this CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
                checkedListBox.SetItemChecked(i, false);
        }
    }

    public static class FormExtensions
    {
        public static void TrimAll(this Form form)
        {
            foreach (var control in form.Controls.OfType<TextBoxBase>())
                control.Text = control.Text.Trim();
        }

        public static string Trim(this TextBoxBase textBox)
        {
            textBox.Text = textBox.Text.Trim();
            return textBox.Text;
        }
    }

    public static class StringExtensions
    {
        public static string ToTrimmed(this string s)
        {
            if (s == null)
                s = string.Empty;
            else
                s = s.Trim();
            return s;
        }

        public static bool IsBlank(this string s) => string.IsNullOrWhiteSpace(s.ToTrimmed());

        public static string Check(this string s) => s.IsBlank() ? throw new ArgumentNullException(nameof(s) + " cannot be null!") : s;
    }
}