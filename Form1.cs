using System.Diagnostics;

namespace GitFromC_;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        this.MinimizeBox = false;
        this.MaximizeBox = false;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;

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

}
