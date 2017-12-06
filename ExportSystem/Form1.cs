using ExportSystem.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportSystem
{
    public partial class Form1 : Form
    {
        SystemController _system;

        public Form1()
        {
            _system = new SystemController("roles.txt");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FieldsValidation())
            {
                var language = RunSystem();
                ShowResultDialog(language);
            }else
            {
                ShowFailedDialog();
            }
        }

        private Variable RunSystem()
        {
            string notMicrosoft = comboNotMicrosoft.Text;
            string algorithms = comboAlgorithms.Text;
            string compilations = comboCompilations.Text;


            _system.Initialize();
            _system.AddKnowledge(
                new List<Variable>()
                {
                    new Variable("notMicrosoft",notMicrosoft),
                    new Variable("algorithms",algorithms),
                    new Variable("compilations",compilations)
                });
            _system.Inference();

            return _system.KnowledgeBase.FirstOrDefault(x => x.Name.Equals("language"));
        }

        private bool FieldsValidation()
        {
            string notMicrosoft = comboNotMicrosoft.Text;
            string algorithms = comboAlgorithms.Text;
            string compilations = comboCompilations.Text;

            if (String.IsNullOrEmpty(notMicrosoft) || String.IsNullOrEmpty(algorithms) || String.IsNullOrEmpty(compilations))
                return false;

            return true;

        }

        private void ShowResultDialog(Variable result)
        {
            string dialogMessage = "";

            if (result == null)
                dialogMessage = "We havent language for you. Maybe should you change proffesion?";
            else
                dialogMessage = string.Format("You should learn {0}. This language was created for you!", result.Value);


            MessageBox.Show(dialogMessage, "XD statement", MessageBoxButtons.OK);
        }
        private void ShowFailedDialog()
        {
            string dialogMessage = "You should complete the form.";
            MessageBox.Show(dialogMessage, "Something went wrong!", MessageBoxButtons.OK);
        }

    }
}
