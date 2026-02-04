using System;

namespace Event
{
    public delegate void ShowMessage(string message);

    public class Button
    {
        public delegate void ClickHandler();
        public event ClickHandler OnClick;

        public void click()
        {
            if (OnClick != null)
            {
                OnClick();
            }
        }
    }

    public class Methods
    {
        public delegate void Notify(); // delegate
        public event Notify ProcessCompleted; // event
        public event Notify ProcessCanceled;

        public void Start()
        {
            Console.WriteLine("Process Started!");
            OnProcessCompleted();
        }
        public void Cancel()
        {
            Console.WriteLine("I am going to Canceled the Process!");
            OnProcessCanceled();
        }
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
        protected virtual void OnProcessCanceled()
        {
            ProcessCanceled?.Invoke();
        }
    }

    public class TaskManager
    {
        public event EventHandler TaskCompleted;

        public void RunTask()
        {
            Console.WriteLine("Task is running...");
            OnTaskCompleted();
        }

        protected virtual void OnTaskCompleted()
        {
            TaskCompleted?.Invoke(this, EventArgs.Empty);
        }
    }

    public class DownloadEventArgs : EventArgs
    {
        public string FileName { get; }
        public DownloadEventArgs(string fileName)
        {
            FileName = fileName;
        }
    }

    public class Downloader
    {
        public event EventHandler<DownloadEventArgs> DownloadCompleted;
        public void Download(string fileName)
        {
            Console.WriteLine($"Downloading {fileName}...");
            OnDownloadCompleted(new DownloadEventArgs(fileName));
        }

        protected virtual void OnDownloadCompleted(DownloadEventArgs e)
        {
            DownloadCompleted?.Invoke(this, e);
        }
    }
}