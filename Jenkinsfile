pipeline {
  agent any
  stages {
    stage('StageBuild') {
      agent any
      steps {
        git(credentialsId: '9ffd8d48d89d555592a4ef1a772f975debf118e9', url: 'https://github.com/humanopower/DDDSample.git', branch: 'master')
      }
    }
  }
  environment {
    Build = 'vio'
  }
}