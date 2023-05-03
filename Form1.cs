using System.Diagnostics;

namespace GitFromC_;

public partial class Form1 : Form
{
    TextBox textBoxGitMerge = new TextBox();
    TextBox textBoxGitBranchCreate = new TextBox();
    TextBox textBoxFileName = new TextBox();

    public Form1()
    {
        InitializeComponent();

        this.MinimizeBox = false;
        this.MaximizeBox = false;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Text = "GitWizard";

        Button btnGitLog = new Button();
        btnGitLog.Text = "Execute Git Log Command";
        btnGitLog.Location = new Point(0, 25);
        btnGitLog.Width = 200;
        btnGitLog.Click += btnGitLog_Click;
        this.Controls.Add(btnGitLog);

        Button btnGitBranch = new Button();
        btnGitBranch.Text = "Execute Git Branch Command";
        btnGitBranch.Location = new Point(0, 50);
        btnGitBranch.Width = 200;
        btnGitBranch.Click += btnGitBranch_Click;
        this.Controls.Add(btnGitBranch);

        Button btnGitBranchCreate = new Button();
        btnGitBranchCreate.Text = "Execute Git Branch [branch_name] Command";
        btnGitBranchCreate.Location = new Point(250, 50);
        btnGitBranchCreate.Width = 200;
        btnGitBranchCreate.Click += btnGitBranchCreate_Click;
        this.Controls.Add(btnGitBranchCreate);

        Button btnGitStatus = new Button();
        btnGitStatus.Text = "Execute Git Status Command";
        btnGitStatus.Location = new Point(0, 75);
        btnGitStatus.Width = 200;
        btnGitStatus.Click += btnGitStatus_Click;
        this.Controls.Add(btnGitStatus);

        Button btnGitDiff = new Button();
        btnGitDiff.Text = "Execute Git Diff Command";
        btnGitDiff.Location = new Point(0, 100);
        btnGitDiff.Width = 200;
        btnGitDiff.Click += btnGitDiff_Click;
        this.Controls.Add(btnGitDiff);

        Button btnGitPull = new Button();
        btnGitPull.Text = "Execute Git Pull Command";
        btnGitPull.Location = new Point(0, 125);
        btnGitPull.Width = 200;
        btnGitPull.Click += btnGitPull_Click;
        this.Controls.Add(btnGitPull);

        Button btnGitInit = new Button();
        btnGitInit.Text = "Execute Git Init Command";
        btnGitInit.Location = new Point(0, 150);
        btnGitInit.Width = 200;
        btnGitInit.Click += btnGitInit_Click;
        this.Controls.Add(btnGitInit);

        Button btnGitMerge = new Button();
        btnGitMerge.Text = "Execute Git Merge Command";
        btnGitMerge.Location = new Point(0, 175);
        btnGitMerge.Width = 200;
        btnGitMerge.Click += btnGitMerge_Click;
        this.Controls.Add(btnGitMerge);

        Button btnGitAddAllFiles = new Button();
        btnGitAddAllFiles.Text = "Execute Git Add -A Command";
        btnGitAddAllFiles.Location = new Point(0, 200);
        btnGitAddAllFiles.Width = 200;
        btnGitAddAllFiles.Click += btnGitAddAllFiles_Click;
        this.Controls.Add(btnGitAddAllFiles);

        Button btnGitAddFiles = new Button();
        btnGitAddFiles.Text = "Execute Git Add -A Command";
        btnGitAddFiles.Location = new Point(250, 200);
        btnGitAddFiles.Width = 200;
        btnGitAddFiles.Click += btnGitAddFiles_Click;
        this.Controls.Add(btnGitAddFiles);

        // Button btnGitToGitHub = new Button();
        // btnGitToGitHub.Text = "Setup GitHub Repo";
        // btnGitToGitHub.Location = new Point(0, 300);
        // btnGitToGitHub.Width = 200;
        // btnGitToGitHub.Click += btnGitToGitHub_Click;
        // this.Controls.Add(btnGitToGitHub);

        
        textBoxGitMerge.PlaceholderText = "Input branch to merge from...";
        textBoxGitMerge.Text = "";
        textBoxGitMerge.Location = new Point(250, 175);
        textBoxGitMerge.Width = 200;
        this.Controls.Add(textBoxGitMerge);

        textBoxGitBranchCreate.PlaceholderText = "Input name of new branch...";
        textBoxGitBranchCreate.Text = "";
        textBoxGitBranchCreate.Location = new Point(500, 50);
        textBoxGitBranchCreate.Width = 200;
        this.Controls.Add(textBoxGitBranchCreate);

        textBoxFileName.PlaceholderText = "Input name of file...";
        textBoxFileName.Text = "";
        textBoxFileName.Location = new Point(500, 200);
        textBoxFileName.Width = 200;
        this.Controls.Add(textBoxFileName);

    }

    private void btnGitLog_Click(object? sender, EventArgs e)
    {
        using (var folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.Description = "Select the working directory for Git command execution.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var workingDirectory = folderBrowserDialog.SelectedPath;

                // Run the Git command using the selected working directory
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "log",
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();

                    var output = process.StandardOutput.ReadToEnd();
                    MessageBox.Show(output);
                }
            }
        }
    }

    private void btnGitBranch_Click(object? sender, EventArgs e)
    {
        using (var folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.Description = "Select the working directory for Git command execution.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var workingDirectory = folderBrowserDialog.SelectedPath;

                // Run the Git command using the selected working directory
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "branch",
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();

                    var output = process.StandardOutput.ReadToEnd();
                    MessageBox.Show(output);
                }
            }
        }
    }

    private void btnGitStatus_Click(object? sender, EventArgs e)
    {
        using (var folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.Description = "Select the working directory for Git command execution.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var workingDirectory = folderBrowserDialog.SelectedPath;

                // Run the Git command using the selected working directory
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "status",
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();

                    var output = process.StandardOutput.ReadToEnd();
                    MessageBox.Show(output);
                }
            }
        }
    }

    private void btnGitDiff_Click(object? sender, EventArgs e)
    {
        using (var folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.Description = "Select the working directory for Git command execution.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var workingDirectory = folderBrowserDialog.SelectedPath;

                // Run the Git command using the selected working directory
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "diff",
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();

                    var output = process.StandardOutput.ReadToEnd();
                    MessageBox.Show(output);
                }
            }
        }
    }

    private void btnGitPull_Click(object? sender, EventArgs e)
    {
        using (var folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.Description = "Select the working directory for Git command execution.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var workingDirectory = folderBrowserDialog.SelectedPath;

                // Run the Git command using the selected working directory
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "pull",
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();

                    var output = process.StandardOutput.ReadToEnd();
                    MessageBox.Show(output);
                }
            }
        }
    }

    private void btnGitInit_Click(object? sender, EventArgs e)
    {
        using (var folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.Description = "Select the working directory for Git command execution.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var workingDirectory = folderBrowserDialog.SelectedPath;

                // Run the Git command using the selected working directory
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "init",
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();

                    var output = process.StandardOutput.ReadToEnd();
                    MessageBox.Show(output);
                }
            }
        }
    }

    private void btnGitMerge_Click(object? sender, EventArgs e)
    {
        using (var folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.Description = "Select the working directory for Git command execution.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var workingDirectory = folderBrowserDialog.SelectedPath;
                var branchToMergeFrom = textBoxGitMerge.Text;

                // Run the Git command using the selected working directory
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "merge " + branchToMergeFrom,
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();

                    var output = process.StandardOutput.ReadToEnd();
                    MessageBox.Show(output);
                }
            }
        }
    }

    private void btnGitBranchCreate_Click(object? sender, EventArgs e)
    {
        using (var folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.Description = "Select the working directory for Git command execution.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var workingDirectory = folderBrowserDialog.SelectedPath;
                var branchToCreate = textBoxGitBranchCreate.Text;

                // Run the Git command using the selected working directory
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "branch " + branchToCreate,
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();

                    var output = process.StandardOutput.ReadToEnd();
                    MessageBox.Show(output);
                }
            }
        }
    }
    

    private void btnGitAddAllFiles_Click(object? sender, EventArgs e) {

        using (var folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.Description = "Select the working directory for Git command execution.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var workingDirectory = folderBrowserDialog.SelectedPath;

                // Run the Git command using the selected working directory
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "add -A",
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();

                    var output = process.StandardOutput.ReadToEnd();
                    MessageBox.Show(output);
                }
            }
        }
    }

    private void btnGitAddFiles_Click(object? sender, EventArgs e) {

        using (var folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.Description = "Select the working directory for Git command execution.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var workingDirectory = folderBrowserDialog.SelectedPath;
                var selectedFile = textBoxFileName.Text;

                // Run the Git command using the selected working directory
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "add " + selectedFile,
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();

                    var output = process.StandardOutput.ReadToEnd();
                    MessageBox.Show(output);
                }
            }
        }
    }
}







//======= IN PROGRESS ===========================================//

//     private void btnGitToGitHub_Click(object? sender, EventArgs e) {
//         gitToGitHub();
//     }

//     public void gitToGitHub() {
//         // create the local git
//         using (var folderBrowserDialog = new FolderBrowserDialog())
//         {
//             folderBrowserDialog.Description = "Select the working directory for Git command execution.";

//             if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
//             {
//                 var workingDirectory = folderBrowserDialog.SelectedPath;
//                 var origin = textBoxGitBranchCreate.Text;
//                 var message = "Test Commit";

//                 // Run the Git command using the selected working directory
//                 // GIT INIT
//                 var processGitInit = new ProcessStartInfo
//                 {
//                     FileName = "git",
//                     Arguments = "init",
//                     WorkingDirectory = workingDirectory,
//                     RedirectStandardOutput = true,
//                     UseShellExecute = false,
//                     CreateNoWindow = true
//                 };

//                 using (var process = new Process())
//                 {
//                     process.StartInfo = processGitInit;
//                     process.Start();

//                     var output = process.StandardOutput.ReadToEnd();
//                     MessageBox.Show(output);
//                 }

//                 // GIT ADD
//                 var processGitAdd = new ProcessStartInfo
//                 {
//                     FileName = "git",
//                     Arguments = "add -A",
//                     WorkingDirectory = workingDirectory,
//                     RedirectStandardOutput = true,
//                     UseShellExecute = false,
//                     CreateNoWindow = true
//                 };

//                 using (var process = new Process())
//                 {
//                     process.StartInfo = processGitAdd;
//                     process.Start();

//                     var output = process.StandardOutput.ReadToEnd();
//                     MessageBox.Show(output);
//                 }

//                 // GIT COMMIT
//                 var processGitCommit = new ProcessStartInfo
//                 {
//                     FileName = "git",
//                     Arguments = "commit -m 'Test Commit'",
//                     WorkingDirectory = workingDirectory,
//                     RedirectStandardOutput = true,
//                     UseShellExecute = false,
//                     CreateNoWindow = true
//                 };

//                 using (var process = new Process())
//                 {
//                     process.StartInfo = processGitCommit;
//                     process.Start();

//                     var output = process.StandardOutput.ReadToEnd();
//                     MessageBox.Show(output);
//                 }

//                 // GIT BRANCH MAIN
//                 var processGitBranch = new ProcessStartInfo
//                 {
//                     FileName = "git",
//                     Arguments = "branch -M main",
//                     WorkingDirectory = workingDirectory,
//                     RedirectStandardOutput = true,
//                     UseShellExecute = false,
//                     CreateNoWindow = true
//                 };

//                 using (var process = new Process())
//                 {
//                     process.StartInfo = processGitBranch;
//                     process.Start();

//                     var output = process.StandardOutput.ReadToEnd();
//                     MessageBox.Show(output);
//                 }

//                 // GIT BRANCH MAIN
//                 var processGitOrigin = new ProcessStartInfo
//                 {
//                     FileName = "git",
//                     Arguments = "remote add origin https://github.com/PipoAT/TestRepo.git",
//                     WorkingDirectory = workingDirectory,
//                     RedirectStandardOutput = true,
//                     UseShellExecute = false,
//                     CreateNoWindow = true
//                 };

//                 using (var process = new Process())
//                 {
//                     process.StartInfo = processGitOrigin;
//                     process.Start();

//                     var output = process.StandardOutput.ReadToEnd();
//                     MessageBox.Show(output);
//                 }

//                 // GIT PUSH
//                 var processGitPush = new ProcessStartInfo
//                 {
//                     FileName = "git",
//                     Arguments = "push -u origin main",
//                     WorkingDirectory = workingDirectory,
//                     RedirectStandardOutput = true,
//                     UseShellExecute = false,
//                     CreateNoWindow = true
//                 };

//                 using (var process = new Process())
//                 {
//                     process.StartInfo = processGitPush;
//                     process.Start();

//                     var output = process.StandardOutput.ReadToEnd();
//                     MessageBox.Show(output);
//                 }
//             }
//         }

//     }
// }
