using System;
using System.Windows.Input;
using LegacyCodeSearcher;


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
            Program searcher = new Program();
            Console.WriteLine(ProjectFolder);
        }

        private String _projectFolder;
    }
}
