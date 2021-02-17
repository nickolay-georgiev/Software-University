import { createTeam } from '../data.js';

export async function create() {
    this.partials = {
        header: await this.load('./templates/common/header.hbs'),
        footer: await this.load('./templates/common/footer.hbs'),
        createForm: await this.load('./templates/create/createForm.hbs'),
    }
    this.partial('./templates/create/createPage.hbs', this.app.userData);
}

export function createPost() {
    const newTeam = {
        name: this.params.name,
        comment: this.params.comment,
        creator: localStorage.getItem('userId')
    }

    if (Object.values(newTeam).some(x => x.length == 0)) {
        alert('All fields are required!');
        return;
    }

    createTeam(newTeam).then((result) => {
        this.app.userData.hasTeam = true;
        this.app.userData.teamId = result.id;
        this.redirect(`#/catalog/${result.id}`);
    }).catch(e => alert(e));
}