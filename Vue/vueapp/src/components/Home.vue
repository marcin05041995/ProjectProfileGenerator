<template>
  <div class="home">
    <bt/>
    <h1>{{ msg }}</h1>
    <h2>Co chcesz zrobić?</h2>
    <router-link to="/employee"><button class="btn btn-primary" style="width:250px;">Przejdź do bazy pracowników</button></router-link><br/><br/>
    <router-link to="/project"><button class="btn btn-info " style="width:250px;">Przejdź do bazy projektów</button></router-link>
  </div>
</template>

<script>
export default {
  name: 'Home',
  data() {
    return {
      msg: 'Witaj w aplikacji do zarządzania pracownikami!',
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
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
