using ProjectTracker.Frontend.Models;

namespace ProjectTracker.Frontend.Clients;

public class ProjectsClient(HttpClient httpClient)
{    
    public async Task<ProjectSummary[]> GetProjectsAsync() 
    => await httpClient.GetFromJsonAsync<ProjectSummary[]>("projects") ?? [];

    public async Task AddProjectAsync(ProjectDetails project)
        => await httpClient.PostAsJsonAsync("projects", project);
    

    public async Task<ProjectDetails> GetProjectAsync(int id)
        => await httpClient.GetFromJsonAsync<ProjectDetails>($"projects/{id}") 
            ?? throw new Exception("Project could not be found");
    

    public async Task UpdateProjectAsync(ProjectDetails updatedProject)
        => await httpClient.PutAsJsonAsync($"projects/{updatedProject.Id}", updatedProject);

    public async Task DeleteProjectAsync(int id)
        => await httpClient.DeleteAsync($"projects/{id}");


}