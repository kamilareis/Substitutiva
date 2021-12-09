import { Component, OnInit } from "@angular/core";

@Component({
    selector: "app-listar-folha",
    templateUrl: "./listar-folha.component.html",
    styleUrls: ["./listar-folha.component.css"],
})
export class ListarFolhaComponent implements OnInit {
    folhas: Folhas[] = [];
    colunasExibidas: String[] = [
        "Id",
        "IdFuncionario",
        "CaixaTexto",
        "ValorHora",
        "MesAno",
        "CriadaEm",
    ];

    constructor(private service: FolhaService) {}

    ngOnInit(): void {
        this.service.list().subscribe((folhas) => {
            this.folhas = folhas;
        });
    }
}