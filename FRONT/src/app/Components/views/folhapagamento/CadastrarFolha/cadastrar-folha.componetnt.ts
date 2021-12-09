import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

@Component({
    selector: "app-cadastrar-folha",
    templateUrl: "./cadastrar-folha.component.html",
    styleUrls: ["./cadastrar-folha.component.css"],
})
export class CadastrarFolhaComponent implements OnInit {
    Id!: number;
    IdFuncionario!: number;
    CaixaTexto!: string;
    ValorHora!: number;
    MesAno!: string;

    cadastrar(): void {
        let folha: Folha = {
            Id: this.Id,
            IdFuncionario: this.IdFuncionario,
            CaixaTexto: this.CaixaTexto,
            ValorHora: this.ValorHora,
            MesAno: this.MesAno,
        };
        this.folhaService.create(folha).subscribe((folha) => {
            console.log(folha);
            this.router.navigate(["folha/listar"]);
        });
    }
}