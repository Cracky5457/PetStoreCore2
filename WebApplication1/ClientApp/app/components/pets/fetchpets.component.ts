import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Pet } from './shared/pet.model';

import { PetService } from './shared/pet.service';


@Component({
    selector: 'fetchdata',
    templateUrl: './fetchpets.component.html'
})
export class FetchPetsComponent {
    public pets: Pet[];

    constructor(private petService: PetService) {

        this.petService.getAllPets().subscribe((pets: Array<Pet>) => {
            this.pets = pets;
        });
    }
}

