using System.Diagnostics;

namespace GitFromC_;

public partial class Form1 : Form
{
    TextBox textBoxGitMerge = new TextBox();

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

        
        textBoxGitMerge.PlaceholderText = "Input branch to merge from...";
        textBoxGitMerge.Text = "";
        textBoxGitMerge.Location = new Point(250, 175);
        textBoxGitMerge.Width = 200;
        this.Controls.Add(textBoxGitMerge);

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
    
    
}
