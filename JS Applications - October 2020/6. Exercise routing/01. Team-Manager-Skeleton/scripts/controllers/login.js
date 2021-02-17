import { loginUser, logout as logoutGet } from '../data.js';

export async function login() {
    this.partials = {
        header: await this.load('./templates/common/header.hbs'),
        footer: await this.load('./templates/common/footer.hbs'),
        loginForm: await this.load('./templates/login/loginForm.hbs'),
    }
    this.partial('./templates/login/loginPage.hbs');    
}

export function loginPost() {

    loginUser(this.params.username, this.params.password)
        .then(result => {
      
            this.app.userData.loggedIn = true;
            this.app.userData.email = result.user.email;
            this.app.userData.userId = result.user.uid;

            localStorage.setItem('user', result.user.email);
            localStorage.setItem('userId', result.user.uid);
            this.redirect('#/home');

        }).catch(e => alert(e));
}

export function logout() {
    logoutGet().then(() => {
        this.app.userData.loggedIn = false;
        this.app.userData.hasTeam = false;

        this.app.userData.teamId = undefined;
        this.app.userData.email = undefined;
        this.app.userData.userId = undefined;

        localStorage.removeItem('user');
        localStorage.removeItem('userId');

        this.redirect('#/home');
    });
}