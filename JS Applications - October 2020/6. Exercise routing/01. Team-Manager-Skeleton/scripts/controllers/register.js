import { registerUser } from '../data.js';

export async function register() {
    this.app.loggedIn = !!localStorage.getItem('user');
    this.partials = {
        header: await this.load('./templates/common/header.hbs'),
        footer: await this.load('./templates/common/footer.hbs'),
        registerForm: await this.load('./templates/register/registerForm.hbs'),
    }
    this.partial('./templates/register/registerPage.hbs');
}

export function registerPost() {

    if (this.params.password !== this.params.repeatPassword) {
        alert('Password don`t match!')
        return;
    }

    registerUser(this.params.username, this.params.password)
        .then(() => {
            this.redirect('#/login');
        }).catch(e => alert(e));
}