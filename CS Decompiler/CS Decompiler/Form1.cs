using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mono;
using Mono.Cecil;
using Mono.Cecil.Cil;
using ICSharpCode;
using System.IO;
using System.Net;
using System.Reflection;
using System.Diagnostics;
using System.Collections;
using ICSharpCode.Decompiler;
using ICSharpCode.NRefactory;
using ICSharpCode.Decompiler.Ast;

namespace CS_Decompiler
{
    public partial class Load : Form
    {
        public AssemblyDefinition LoadedAsmbly { get; set; }
        public bool status = false;
        public Load()
        {
            InitializeComponent();
        }
        private void ResetData()
        {
            this.member_tree.Nodes.Clear();
            this.richTextBox1.Clear();
            this.richTextBox2.Clear();
            this.textBox1.Clear();
        }
        private void path_button_Click(object sender, EventArgs e)
        {
            status = false;
            ResetData();
            GetBinary();
        }
        private void GetBinary()
        {
            OpenFileDialog openAsm = new OpenFileDialog();
            openAsm.Filter = "Executable | *.exe";
            if (openAsm.ShowDialog() == DialogResult.OK)
            {
                FilePath_edit.Text = openAsm.FileName;
                GetBinaryInformation();
                if (status == false)
                {
                    GetAsmLoadContents();
                }
            }
        }

        private void GetBinaryInformation()
        {
            try
            {
                LoadedAsmbly = AssemblyDefinition.ReadAssembly(FilePath_edit.Text);

                textBox1.Clear();
                textBox1.AppendText("[*] Name :: " + LoadedAsmbly.MainModule.Name.ToString() + Environment.NewLine);
                textBox1.AppendText("[*] CLR Runtime:: " + LoadedAsmbly.MainModule.Runtime.ToString() + Environment.NewLine);
                textBox1.AppendText("[*] Full Name:: " + LoadedAsmbly.MainModule.FullyQualifiedName.ToString() + Environment.NewLine);
                textBox1.AppendText("[*] Metadata Token:: " + LoadedAsmbly.MainModule.MetadataToken.ToString() + Environment.NewLine);
                textBox1.AppendText("[*] Architecture:: " + LoadedAsmbly.MainModule.Architecture.ToString() + Environment.NewLine);
                textBox1.AppendText("[*] EntryPoint:: " + LoadedAsmbly.MainModule.EntryPoint.ToString() + Environment.NewLine);
                textBox1.AppendText("[*] Mvid:: " + LoadedAsmbly.MainModule.EntryPoint.ToString() + Environment.NewLine);
            }
            catch
            {
                ResetData();
                MessageBox.Show("[Error] Couldn't Read Assembly.");
                status = true;
                return;
            }
        }
        private void GetAsmLoadContents() // TreeNode 객체
        {
            LoadedAsmbly = AssemblyDefinition.ReadAssembly(FilePath_edit.Text);
            TreeNode tn = null;
            IEnumerator e = LoadedAsmbly.MainModule.Types.GetEnumerator();
            while (e.MoveNext())
            {
                TypeDefinition td = (TypeDefinition)e.Current;

                tn = this.member_tree.Nodes.Add(td.Name.ToString());
                IEnumerator e2 = td.Methods.GetEnumerator();
                while (e2.MoveNext())
                {
                    MethodDefinition method = (MethodDefinition)e2.Current;
                    if (method.IsConstructor)
                    {
                        tn.Nodes.Add(method.Name.ToString());
                    }
                    tn.Nodes.Add(method.Name.ToString());
                }
            }
        }

        private void DecompileCsharpCode()
        {
            var asm = AssemblyDefinition.ReadAssembly(FilePath_edit.Text);
            IEnumerator e = asm.MainModule.Types.GetEnumerator();

            while (e.MoveNext())
            {
                TypeDefinition td = (TypeDefinition)e.Current;
                IEnumerator e2 = td.Methods.GetEnumerator();
                while (e2.MoveNext())
                {
                    MethodDefinition method = (MethodDefinition)e2.Current;
                    AstBuilder ast = null;

                    foreach (var type in asm.MainModule.Types)
                    {
                        ast = new AstBuilder(new DecompilerContext(asm.MainModule) { CurrentType = type });
                        foreach (var method2 in type.Methods)
                        {
                            if (method2.Name == member_tree.SelectedNode.Text)
                            {
                                this.richTextBox1.Clear();
                                ast.AddMethod(method2);
                                StringWriter output = new StringWriter();
                                ast.GenerateCode(new PlainTextOutput(output));
                                string result = output.ToString();
                                this.richTextBox1.AppendText(result);
                                output.Dispose();
                            }
                        }
                    }
                }
            }
        }
        private void DisassembleILCode()
        {
            var asm = AssemblyDefinition.ReadAssembly(this.FilePath_edit.Text);
            IEnumerator e = asm.MainModule.Types.GetEnumerator();

            while (e.MoveNext())
            {
                TypeDefinition td = (TypeDefinition)e.Current;
                if (td.Name == member_tree.SelectedNode.Parent.Text)
                {
                    IEnumerator e2 = td.Methods.GetEnumerator();
                    while (e2.MoveNext())
                    {
                        MethodDefinition method = (MethodDefinition)e2.Current;
                        if (method.Name == member_tree.SelectedNode.Text && !method.IsSetter && !method.IsGetter)
                        {
                            this.richTextBox2.Clear();
                            ILProcessor cil = method.Body.GetILProcessor();
                            foreach (Instruction inst in cil.Body.Instructions)
                            {
                                this.richTextBox2.AppendText(inst + Environment.NewLine);
                            }
                        }
                    }
                }
            }
        }

        private void member_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                DecompileCsharpCode();
                DisassembleILCode();
            }
            catch
            {
                MessageBox.Show("[Error]");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}