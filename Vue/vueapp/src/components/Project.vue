<template>
  <div class="projectclass">
  <h1>Widok projektu</h1>


    <br/><br/><br/>
    <div class="col-lg-2"></div>
    <div class="col-lg-7">
      <router-link to="/addproject"><button class="btn btn-primary"
        style="float:left; margin-bottom:20px;">Dodaj projekt</button></router-link>
          <table class="table table-hover">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Projekt</th>
                    <!-- <th>Wykonawca</th> -->
                </tr>
            </thead>
            <tbody>
                <tr>
                <tr v-for="p in projects" :key="p.Id" >
                    <td align="left">{{p.profileProject.id}}</td>
                    <td align="left">{{p.profileProject.name}}</td>
                    <!-- <td align="left">{{p.profileProject.profile.id}}</td> -->
                    <td style="margin-left:5px;">
                      <router-link to="/editproject"><button class="btn btn-primary">Edytuj</button></router-link>
                      <button class="btn btn-danger">Usuń</button>
                      <router-link to="projectinfoview"><button class="btn btn-info" v-on:click="getID">Informacje</button></router-link>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    <div class="col-lg-3"></div>
  </div>
</template>

<script>
// https://alligator.io/vuejs/rest-api-axios/
// Access-Control-Allow-Origin: *

import axios from 'axios';

export default {
  data() {
    return {
      projects: [],
      project: [],
      errors: []
    }
  },

  // Fetches posts when the component is created.
  created() {
    axios.get(`http://localhost:4444/api/projects/GetProjects`)
    .then(response => {
      console.log('asdaqwe')
      // JSON responses are automatically parsed.
        this.projects = response.data;
      })
      .catch(e => {
        this.errors.push(e);
      });
  },

  // methods:{
  //   getID(){
  //       axios.get('http://localhost:4444/api/projects/GetProject?id=86904cf4-0a67-487c-3f3c-08d5fc3f39c7')
  //       .then(response =>{
  //         this.projects=response.data;
  //       })
  //   }
  // }
};

</script>


<style scoped>
h1, h2 {
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
