namespace Repeated_Numbers_UI
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRoundNumber = new System.Windows.Forms.Button();
            this.lblRoundTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnNumberRepeat = new System.Windows.Forms.Button();
            this.mtbNumberRepeted = new System.Windows.Forms.MaskedTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.lblIsCorrect = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Repeated Numbers Game";
            // 
            // btnRoundNumber
            // 
            this.btnRoundNumber.BackColor = System.Drawing.Color.Blue;
            this.btnRoundNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoundNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoundNumber.ForeColor = System.Drawing.Color.White;
            this.btnRoundNumber.Location = new System.Drawing.Point(35, 74);
            this.btnRoundNumber.Name = "btnRoundNumber";
            this.btnRoundNumber.Size = new System.Drawing.Size(130, 57);
            this.btnRoundNumber.TabIndex = 4;
            this.btnRoundNumber.TabStop = false;
            this.btnRoundNumber.Text = "Round";
            this.btnRoundNumber.UseVisualStyleBackColor = false;
            // 
            // lblRoundTime
            // 
            this.lblRoundTime.AutoSize = true;
            this.lblRoundTime.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundTime.ForeColor = System.Drawing.Color.Blue;
            this.lblRoundTime.Location = new System.Drawing.Point(65, 291);
            this.lblRoundTime.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblRoundTime.Name = "lblRoundTime";
            this.lblRoundTime.Size = new System.Drawing.Size(30, 33);
            this.lblRoundTime.TabIndex = 5;
            this.lblRoundTime.Text = "0";
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(29, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "How Many Times Was Repeated:";
            // 
            // btnNumberRepeat
            // 
            this.btnNumberRepeat.BackColor = System.Drawing.Color.Blue;
            this.btnNumberRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumberRepeat.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberRepeat.ForeColor = System.Drawing.Color.White;
            this.btnNumberRepeat.Location = new System.Drawing.Point(180, 160);
            this.btnNumberRepeat.Name = "btnNumberRepeat";
            this.btnNumberRepeat.Size = new System.Drawing.Size(44, 43);
            this.btnNumberRepeat.TabIndex = 8;
            this.btnNumberRepeat.TabStop = false;
            this.btnNumberRepeat.Text = "0";
            this.btnNumberRepeat.UseVisualStyleBackColor = false;
            // 
            // mtbNumberRepeted
            // 
            this.mtbNumberRepeted.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mtbNumberRepeted.Location = new System.Drawing.Point(199, 282);
            this.mtbNumberRepeted.Mask = "0";
            this.mtbNumberRepeted.Name = "mtbNumberRepeted";
            this.mtbNumberRepeted.Size = new System.Drawing.Size(67, 38);
            this.mtbNumberRepeted.TabIndex = 0;
            this.mtbNumberRepeted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbNumberRepeted.ValidatingType = typeof(System.DateTime);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(169, 326);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 34);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(364, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 43);
            this.button3.TabIndex = 11;
            this.button3.TabStop = false;
            this.button3.Tag = "buttonNumber";
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(364, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 43);
            this.button4.TabIndex = 12;
            this.button4.TabStop = false;
            this.button4.Tag = "buttonNumber";
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(364, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 43);
            this.button5.TabIndex = 13;
            this.button5.TabStop = false;
            this.button5.Tag = "buttonNumber";
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Blue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(364, 277);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 43);
            this.button6.TabIndex = 14;
            this.button6.TabStop = false;
            this.button6.Tag = "buttonNumber";
            this.button6.Text = "0";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(364, 324);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 43);
            this.button7.TabIndex = 15;
            this.button7.TabStop = false;
            this.button7.Tag = "buttonNumber";
            this.button7.Text = "0";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(314, 324);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 43);
            this.button8.TabIndex = 20;
            this.button8.TabStop = false;
            this.button8.Tag = "buttonNumber";
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Blue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(314, 277);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 43);
            this.button9.TabIndex = 19;
            this.button9.TabStop = false;
            this.button9.Tag = "buttonNumber";
            this.button9.Text = "0";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Blue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(314, 230);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(44, 43);
            this.button10.TabIndex = 18;
            this.button10.TabStop = false;
            this.button10.Tag = "buttonNumber";
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Blue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(314, 183);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(44, 43);
            this.button11.TabIndex = 17;
            this.button11.TabStop = false;
            this.button11.Tag = "buttonNumber";
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Blue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(314, 136);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(44, 43);
            this.button12.TabIndex = 16;
            this.button12.TabStop = false;
            this.button12.Tag = "buttonNumber";
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Blue;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(414, 324);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(44, 43);
            this.button13.TabIndex = 25;
            this.button13.TabStop = false;
            this.button13.Tag = "buttonNumber";
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Blue;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(414, 277);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(44, 43);
            this.button14.TabIndex = 24;
            this.button14.TabStop = false;
            this.button14.Tag = "buttonNumber";
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Blue;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(414, 230);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(44, 43);
            this.button15.TabIndex = 23;
            this.button15.TabStop = false;
            this.button15.Tag = "buttonNumber";
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Blue;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(414, 183);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(44, 43);
            this.button16.TabIndex = 22;
            this.button16.TabStop = false;
            this.button16.Tag = "buttonNumber";
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Blue;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(414, 136);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(44, 43);
            this.button17.TabIndex = 21;
            this.button17.TabStop = false;
            this.button17.Tag = "buttonNumber";
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Blue;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(464, 324);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(44, 43);
            this.button18.TabIndex = 30;
            this.button18.TabStop = false;
            this.button18.Tag = "buttonNumber";
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Blue;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(464, 277);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(44, 43);
            this.button19.TabIndex = 29;
            this.button19.TabStop = false;
            this.button19.Tag = "buttonNumber";
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Blue;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(464, 230);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(44, 43);
            this.button20.TabIndex = 28;
            this.button20.TabStop = false;
            this.button20.Tag = "buttonNumber";
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Blue;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(464, 183);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(44, 43);
            this.button21.TabIndex = 27;
            this.button21.TabStop = false;
            this.button21.Tag = "buttonNumber";
            this.button21.Text = "0";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Blue;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(464, 136);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(44, 43);
            this.button22.TabIndex = 26;
            this.button22.TabStop = false;
            this.button22.Tag = "buttonNumber";
            this.button22.Text = "0";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Blue;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(514, 324);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(44, 43);
            this.button23.TabIndex = 35;
            this.button23.TabStop = false;
            this.button23.Tag = "buttonNumber";
            this.button23.Text = "0";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Blue;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(514, 277);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(44, 43);
            this.button24.TabIndex = 34;
            this.button24.TabStop = false;
            this.button24.Tag = "buttonNumber";
            this.button24.Text = "0";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Blue;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button25.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(514, 230);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(44, 43);
            this.button25.TabIndex = 33;
            this.button25.TabStop = false;
            this.button25.Tag = "buttonNumber";
            this.button25.Text = "0";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Blue;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button26.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(514, 183);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(44, 43);
            this.button26.TabIndex = 32;
            this.button26.TabStop = false;
            this.button26.Tag = "buttonNumber";
            this.button26.Text = "0";
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Blue;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button27.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(514, 136);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(44, 43);
            this.button27.TabIndex = 31;
            this.button27.TabStop = false;
            this.button27.Tag = "buttonNumber";
            this.button27.Text = "0";
            this.button27.UseVisualStyleBackColor = false;
            // 
            // lblIsCorrect
            // 
            this.lblIsCorrect.AutoSize = true;
            this.lblIsCorrect.Font = new System.Drawing.Font("Roboto", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblIsCorrect.Location = new System.Drawing.Point(195, 259);
            this.lblIsCorrect.Name = "lblIsCorrect";
            this.lblIsCorrect.Size = new System.Drawing.Size(71, 20);
            this.lblIsCorrect.TabIndex = 36;
            this.lblIsCorrect.Text = "Correct!";
            this.lblIsCorrect.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Repeated_Numbers.Properties.Resources.stopwatch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // frmGame
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(211)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(580, 391);
            this.Controls.Add(this.lblRoundTime);
            this.Controls.Add(this.lblIsCorrect);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.mtbNumberRepeted);
            this.Controls.Add(this.btnNumberRepeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRoundNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmGame";
            this.Text = "Repeated Numbers Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRoundNumber;
        private System.Windows.Forms.Label lblRoundTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNumberRepeat;
        private System.Windows.Forms.MaskedTextBox mtbNumberRepeted;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Label lblIsCorrect;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}