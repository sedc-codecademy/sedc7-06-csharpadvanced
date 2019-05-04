Step1: Form
- Text: HangMan
- MinSize: 755, 550
- MaxSize: 755, 550
- StartPosition: CenterScreen

Step2: Buttons
- Size: 35, 35
- Location: 40, 385
- TabIndex: 0..25
- Text: A..Z

Step3: btnNew
- Size: 117, 35
- TabIndex: 26
- Text: New
- Name: btnNew

Step4: ComboBox
- Size: 117,21
- Location: 584, 43
- Items: MK Cities, Countries
- Text: MK Cities

Step5: Variables
- string[] mk_cities
"Skopje", "Stip", "Bitola", "Veles", "Tetovo", "Kumanovo", "Strumica",
            "Kocani", "Vinica","Delcevo","Gevgelija","Ohrid","Resen","Prilep","Kavadarci","Gostivar",
        "Negotino","Berovo","Kicevo","Struga","Radovis","Valandovo","Debar","Dojran","Probistip","Kratovo",
        "Demirhisar","KrivaPalanka","Pehcevo","Dracevo","DemirKapija","Bogdanci"
- string[] countries
"Macedonia", "Bulgaria", "Greece", "Serbia", "Albania", "Turkey",
            "Croatia", "Bosnia","Germany","Italy","Spain","Portugal","France","England","Sweden","Norway",
        "Romania","Russia","Chehia","Slovakia","Poland","Denmark","Finland","Belgium","Switzerland",
        "Austria","Slovenia","Malta","Ireland","Estonia","Ukraine","Georgia","Ermenia","Cyprus","Belorussia",
        "Hungary","Latvia","Iceland","Moldova","Israel","Luxembourg","Netherlands","Andora","Azerbaijan"
- string[] words
- string randomWord
- Random rnd = new Random()
- List<Label> labels
- Button[] alphabetButtons
- bool ignore = false
- int stage = 0

Step6: Methods
= Form1_Load()
- this.DoubleBuffered = true
- alphabetButtons = get all buttons from controls except btnNew
- add event handler btn_Click to all buttons from alphabetButtons
- btnNew.PerformClick()
= btnNew_Click()
- set words to mk_cities or countries
- randomWord = new random word from words
- dispose all lbl
- enable all buttons from alphabetButtons
- create labels list
- foreach letter in randomWord create new label
- lbl.Location = new Point(button1.Left, 250)
- lbl.Text = " "

- lbl.Font = new Font(this.Font.Name, 25, FontStyle.Underline)
- lbl.Tag = letter
- lbl.AutoSize = true
- this.Controls.Add(lbl)
- labels.Add(lbl)
- set ignore = false, stage = 0
- this.Invalidate()
= btn_Click()
- btn.Enabled = false
- show text to label if btn.Text == lbl.Tag
- correct lbl positions
- iterate stage if all lbl.Text != btn.Text
- set ignore = true if all lbl.Text != " " || stage == 10
- this.Invalidate()
- check YouDidIt()
- check YouLostIt()
= comboBox1_TextChanged()
- this.DoubleBuffered = true
- btnNew.PerformClick()
= YouDidIt()
- return all lbl.Text != " "
= YouLostIt()
- return stage >= 10
= Form1_Paint()
- if (stage >= 1) e.Graphics.DrawLine(new Pen(Color.Black, 2), 85, 190, 210, 190)
- if (stage >= 2) e.Graphics.DrawLine(new Pen(Color.Black, 2), 148, 190, 148, 50)
- if (stage >= 3) e.Graphics.DrawLine(new Pen(Color.Black, 2), 148, 50, 198, 50)
- if (stage >= 4) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 50, 198, 70)
- if (stage >= 5) e.Graphics.DrawEllipse(new Pen(Color.Black, 2), new Rectangle(188, 70, 20, 20))
- if (stage >= 6) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 90, 198, 130)
- if (stage >= 7) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 95, 183, 115)
- if (stage >= 8) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 95, 213, 115)
- if (stage >= 9) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 130, 183, 170)
- if (stage >= 10) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 130, 213, 170)