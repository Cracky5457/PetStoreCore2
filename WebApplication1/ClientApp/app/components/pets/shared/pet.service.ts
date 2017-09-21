import { EventEmitter, Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';

import { Pet } from './pet.model';

import { Component, Inject} from '@angular/core';
import { Observable } from 'rxjs/Observable';

// Import RxJs required methods
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable()
export class PetService {

    request$: EventEmitter<any>;

    private petsUrl: string;

    constructor(private http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.request$ = new EventEmitter();
        this.petsUrl = baseUrl+"api/pet";
    }

    getAllPets(): Observable<Pet[]> {
        this.request$.emit('starting');

        return this.http.get(this.petsUrl)
            // ...and calling .json() on the response to return data
            .map((res: Response) => res.json())
            //...errors if any
            .catch((error: any) => Observable.throw(error.json().error || 'Server error'));

    }
}