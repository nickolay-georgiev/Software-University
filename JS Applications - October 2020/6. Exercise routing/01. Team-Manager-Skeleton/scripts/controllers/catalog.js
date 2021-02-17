import { getTeamById, getTeams } from '../data.js';

export async function catalog() {
    this.partials = {
        header: await this.load('./templates/common/header.hbs'),
        footer: await this.load('./templates/common/footer.hbs'),
        team: await this.load('./templates/catalog/team.hbs'),
    }

    getTeams().then(res => {
        let teams = res.docs.map(doc => doc.data());
        const data = Object.assign({ teams }, this.app.userData);
        this.partial('./templates/catalog/teamCatalog.hbs', data);
    });

}

export async function details() {
    this.partials = {
        header: await this.load('./templates/common/header.hbs'),
        footer: await this.load('./templates/common/footer.hbs'),
        teamControls: await this.load('./templates/catalog/teamControls.hbs'),
        teamMember: await this.load('./templates/catalog/teamMember.hbs'),
    }

    getTeamById(this.params.id).then(res => {
        let data = Object.assign(res.data(), this.app.userData);
        debugger;

        if (data.creator === this.app.userData.userId) {
            data.isAuthor = true;
        }

        if (data.objectId === this.app.userData.teamId) {
            data.isOnTeam = true;
        }

        this.partial('./templates/catalog/details.hbs', data);
    });
}