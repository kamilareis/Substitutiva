import { Router } from '@angular/router';
import { Component, OnInit } from "@angular/core";
import { Funcionario } from "src/app/models/funcionario";
import { FuncionarioService } from "src/app/services/funcionario.service";

@Component({
    selector: "app-cadastrar-funcionario",
    templateUrl: "./cadastrar-funcionario.component.html",
    styleUrls: ["./cadastrar-funcionario.component.css"],
})
export class CadastrarFuncionario implements OnInit {
    Id!: number;
    Cpf!: number;
    Nome!: string;


    cadastrar(): void {
        let funcionario: Funcionario = {
            Id: this.Id,
            Cpf: this.Cpf,
            Nome: this.Nome,
        };
        this.funcionarioService.create(funcionario).subscribe((funcionario) => {
            console.log(funcionario);
            this.Router.navigate(["funcionario/listar"]);
        });
    }
}