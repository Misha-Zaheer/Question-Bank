using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class MCQUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Button1.Visible = true;
            Panel1.Visible = false;
            Panel2.Visible = false;

            TextBox1.Visible = false;           //panel3 items
            AddOption.Visible = false;
            CheckBox1.Visible = false;

            NoMoreOption.Visible = false;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;

        TextBox1.Visible = false;          
        AddOption.Visible = false;
        CheckBox1.Visible = false;

        NoMoreOption.Visible = false;
        Button1.Visible = false;
    }

    protected void QuestionAddButton_Click(object sender, EventArgs e)
    {
        //DreamBirdEntities db = new DreamBirdEntities();
        //Question question = new Question();
        //string questionText = "MyString";
        //question.QuestionText = questionText;
        //db.Questions.Add(question);
        //db.SaveChanges();
        //int id = question.id;
        //List<Question> lst = db.Questions.Where(w => w.id > 1 && w.id < 10).ToList();
        //Question questiontoFetch = db.Questions.Where(w => w.id == 5).First();

        QuestionBankEntities db = new QuestionBankEntities();
        QUESTION q = new QUESTION ();

        if (QuestionTextBox.Text != null)
        {
            ////////////////// 
            q.QUESTIONTEXT = QuestionTextBox.Text;
            QuestionLabel.Text = q.QUESTIONTEXT;
            db.QUESTIONS.Add(q);
            db.SaveChanges();
            int id = q.ID;
            ViewState["data"] = id;
            ////////////////////

            Panel2.Visible = true;
            Panel1.Visible = false;

            TextBox1.Visible = true;           //panel3 items
            AddOption.Visible = true;
            CheckBox1.Visible = true;

            QuestionTextBox.Text = "";
            Button1.Visible = false;
            NoMoreOption.Visible = true;
        }
    }
    protected void QuestionLabel_Load(object sender, EventArgs e)
    {
    }

    protected void AddOption_Click(object sender, EventArgs e)
    {
        //MCQQuestion pre = Session["data"] as MCQQuestion;
        //MCQOption op = new MCQOption();
        // use op with status and option

        QuestionBankEntities db = new QuestionBankEntities();
        OPTION op = new OPTION();

        int id = (int)(ViewState["data"]);
        op.QUESTIONS = id;

        if (TextBox1.Text != null)
        {
            op.OOPTION = TextBox1.Text;
            Label2.Text = op.OOPTION + "<br/>";

            if (CheckBox1.Checked)
            {
                op.OSTATUS = true;
                Label3.Text = "yes";
            }
            else
            {
               op.OSTATUS = false;
                Label3.Text = "no";
            }

            db.OPTIONS.Add(op);
            db.SaveChanges();
            //pre.Options.Add(op);
            //Session["data"] = pre;

            Panel1.Visible = false;

            TextBox1.Visible = true;           //panel3 items
            AddOption.Visible = true;
            CheckBox1.Visible = true;

            NoMoreOption.Visible = true;

        }
    }

    protected void NoMoreOption_Click(object sender, EventArgs e)
    {
       // MCQQuestion pre = Session["data"] as MCQQuestion;
        Repeater1.DataSource = null;
       // Repeater1.DataSource = pre.Options;
        Repeater1.DataBind();
        Button1.Visible = true;

        Panel1.Visible = false;
        Panel2.Visible = false;

        TextBox1.Visible = false;           //panel3 items
        AddOption.Visible = false;
        CheckBox1.Visible = false;

        NoMoreOption.Visible = false;
        Label3.Text = "";
        Label2.Text = "";

    }

    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            Label lb1 = e.Item.FindControl("OptionLabel") as Label;
            Button btn = e.Item.FindControl("OptionButtonDelete") as Button;
            Label lb2 = e.Item.FindControl("StatusLabel") as Label;
            lb1.Text = Label2.Text;
            lb2.Text = Label3.Text;
        }
    }

    protected void Label1_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }
}