namespace ContainerLibrary.Container;

public interface IContainerRepository
{
    int AddNewContainer();
    bool RemoveContainer(int id);
}
