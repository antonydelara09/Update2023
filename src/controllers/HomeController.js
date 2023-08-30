import Aluno from '../models/Aluno';

class HomeController {
  async index(req, res) {
    const novoAluno = await Aluno.create({
      nome: 'Almir',
      sobrenome: 'Gabriel',
      email: 'almir@gmail.com',
      idade: 81,
      peso: 49,
      altura: 1.75,
    });
    res.json(novoAluno);
  }
}

export default new HomeController();
