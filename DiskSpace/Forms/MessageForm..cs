﻿#region Using statements

using System;
using System.Drawing;
using System.Windows.Forms;
using DiskSpace.Properties;

#endregion

namespace DiskSpace.Forms
{
    /// <summary>
    /// Settings form
    /// </summary>
    public partial class MessageForm : Form
    {

        #region Public methods

        /// <summary>
        /// Set message to display in form
        /// </summary>
        /// <param name="text"></param>
        public void SetMessage(string text) => lblMessage.Text = text;

        #endregion

        #region Private member variables

        #endregion

        #region Protected class properties

        /// <summary>
        /// Mouse location offset used form form movement
        /// </summary>
        protected Point Offset { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Settings form constructor
        /// </summary>
        public MessageForm()
        {
            InitializeComponent();
            SetControlTexts();
        }

        #endregion

        #region Events handling

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsTitle_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateOffset(e);
        }

        private void SettingsTitle_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void MinimizePanel_MouseEnter(object sender, EventArgs e)
        {
            FocusMinimizeIcon();
        }

        private void MinimizePanel_MouseLeave(object sender, EventArgs e)
        {
            UnfocusMinimizeIcon();
        }

        private void MinimizePanel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizePanelFrame_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Private methods

        private void SetControlTexts()
        {
            btnOK.Text = Resources.OK;
            lblMessageFormTitle.Text = Resources.MessageTitle;
            Text = Resources.MessageTitle;
        }

        private void FocusMinimizeIcon()
        {
            minimizePanel.BackColor = Color.LightGray;
        }

        private void MoveForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Top = Cursor.Position.Y - Offset.Y;
                Left = Cursor.Position.X - Offset.X;
            }
        }

        private void UpdateOffset(MouseEventArgs e)
        {
            Offset = new Point(e.X, e.Y);
        }

        private void UnfocusMinimizeIcon()
        {
            minimizePanel.BackColor = Color.White;
        }

        #endregion
    }
}