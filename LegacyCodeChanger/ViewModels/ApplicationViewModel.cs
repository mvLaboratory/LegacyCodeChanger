using System;
using System.Windows.Input;

namespace LegacyCodeChanger
{
    class ApplicationViewModel : BaseViewModel
    {
        public String ProjectFolder {
            get
            {
                return _projectFolder;
            }
            set
            {
                _projectFolder = value;
            }
        }

        public String TagSelector { get; set; }

        public ICommand SearchBtnCkick { get; set; }

        public ApplicationViewModel()
        {
            SearchBtnCkick = new RelayCommand(doSearch);
        }

        public void doSearch()
        {
            Console.WriteLine(ProjectFolder);
        }

        private String _projectFolder;
    }
}
