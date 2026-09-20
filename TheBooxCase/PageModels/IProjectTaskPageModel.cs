using CommunityToolkit.Mvvm.Input;
using TheBooxCase.Models;

namespace TheBooxCase.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}