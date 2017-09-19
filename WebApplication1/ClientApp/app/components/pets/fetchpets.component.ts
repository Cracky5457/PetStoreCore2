import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Pet } from './shared/pet.model';


@Component({
    selector: 'fetchdata',
    templateUrl: './fetchpets.component.html'
})
export class FetchPetsComponent {
    public pets: Pet[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/pet').subscribe(result => {
            this.pets = result.json() as Pet[];
        }, error => console.error(error));
    }
}

