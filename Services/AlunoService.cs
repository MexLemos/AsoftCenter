public class AlunoService
{
    private List<Aluno> alunos= new ();
    public List<Aluno> GetAll()
    {
        return alunos;
    }

    public void Add(Aluno aluno)
    {
        alunos.Add(aluno);
    }
    
    private void Excluir(Aluno aluno)
    {
        alunos.Remove(aluno);
    }    
    public Aluno Get(int index)
    {
        return alunos[index];
    }
    
    
}