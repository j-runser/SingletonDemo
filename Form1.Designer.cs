namespace SingletonDemo
{
    partial class Form1
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
            this.btn_rock = new System.Windows.Forms.Button();
            this.btn_stick = new System.Windows.Forms.Button();
            this.btn_dirt = new System.Windows.Forms.Button();
            this.btn_dropItem = new System.Windows.Forms.Button();
            this.lbl_hand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_rock
            // 
            this.btn_rock.Location = new System.Drawing.Point(17, 16);
            this.btn_rock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_rock.Name = "btn_rock";
            this.btn_rock.Size = new System.Drawing.Size(200, 188);
            this.btn_rock.TabIndex = 0;
            this.btn_rock.Text = "Rock";
            this.btn_rock.UseVisualStyleBackColor = true;
            this.btn_rock.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_stick
            // 
            this.btn_stick.Location = new System.Drawing.Point(16, 211);
            this.btn_stick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_stick.Name = "btn_stick";
            this.btn_stick.Size = new System.Drawing.Size(200, 188);
            this.btn_stick.TabIndex = 1;
            this.btn_stick.Text = "Stick";
            this.btn_stick.UseVisualStyleBackColor = true;
            this.btn_stick.Click += new System.EventHandler(this.btn_stick_Click);
            // 
            // btn_dirt
            // 
            this.btn_dirt.Location = new System.Drawing.Point(16, 406);
            this.btn_dirt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dirt.Name = "btn_dirt";
            this.btn_dirt.Size = new System.Drawing.Size(200, 188);
            this.btn_dirt.TabIndex = 2;
            this.btn_dirt.Text = "Dirt";
            this.btn_dirt.UseVisualStyleBackColor = true;
            this.btn_dirt.Click += new System.EventHandler(this.btn_dirt_Click);
            // 
            // btn_dropItem
            // 
            this.btn_dropItem.Location = new System.Drawing.Point(224, 406);
            this.btn_dropItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dropItem.Name = "btn_dropItem";
            this.btn_dropItem.Size = new System.Drawing.Size(661, 188);
            this.btn_dropItem.TabIndex = 3;
            this.btn_dropItem.Text = "Drop";
            this.btn_dropItem.UseVisualStyleBackColor = true;
            this.btn_dropItem.Click += new System.EventHandler(this.btn_dropItem_Click);
            // 
            // lbl_hand
            // 
            this.lbl_hand.AutoSize = true;
            this.lbl_hand.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hand.Location = new System.Drawing.Point(513, 194);
            this.lbl_hand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hand.Name = "lbl_hand";
            this.lbl_hand.Size = new System.Drawing.Size(0, 79);
            this.lbl_hand.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 806);
            this.Controls.Add(this.lbl_hand);
            this.Controls.Add(this.btn_dropItem);
            this.Controls.Add(this.btn_dirt);
            this.Controls.Add(this.btn_stick);
            this.Controls.Add(this.btn_rock);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rock;
        private System.Windows.Forms.Button btn_stick;
        private System.Windows.Forms.Button btn_dirt;
        private System.Windows.Forms.Button btn_dropItem;
        private System.Windows.Forms.Label lbl_hand;
    }
}

