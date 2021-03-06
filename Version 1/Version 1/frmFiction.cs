﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookStore3
{
    public partial class frmFiction : BookStore3.frmBook
    {
        public static readonly frmFiction Instance = new frmFiction();
        public frmFiction()
        {
            InitializeComponent();
        }

        public static void Run(clsFiction prFiction)
        {
            Instance.SetDetails(prFiction);
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsFiction lcBook = (clsFiction)this._Book;
            txtLetterCode.Text = lcBook.LetterCode;
        }

        protected override void pushData()
        {
            base.pushData();
            clsFiction lcBook = (clsFiction)_Book;
            lcBook.LetterCode = txtLetterCode.Text;
        }
    }
}
