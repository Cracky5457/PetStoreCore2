import { Tag } from './tag.model';

export class Pet {
    id: number;
    name: string;
    status: string;
    tags: Tag[];

    constructor(id: number,
        name: string) {

    }
}